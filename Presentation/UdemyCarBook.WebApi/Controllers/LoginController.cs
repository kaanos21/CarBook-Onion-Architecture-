using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UdemyCarBook.Application.Features.Mediator.Quaries.AppUserQueries;
using UdemyCarBook.Application.Tools;

namespace UdemyCarBook.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly IMediator _mediator;

        public LoginController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpPost]
        public async Task<IActionResult> Index(GetCheckAppUserQuery query)
        {
            try
            {
                var values = await _mediator.Send(query);
                if (values.IsExist)
                {
                    return Created("", JwtTokenGenerator.GenerateToken(values));
                }
                else
                {
                    return BadRequest("Kullanıcı adı veya şifre hatalıdır");
                }
            }
            catch (Exception ex)
            {
                // Hata mesajını loglayın
                Console.WriteLine($"Hata: {ex.Message}");
                return StatusCode(500, "Sunucu hatası oluştu");
            }
        }
    }
}
