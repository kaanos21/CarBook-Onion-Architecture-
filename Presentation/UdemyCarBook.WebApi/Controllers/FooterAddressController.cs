using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UdemyCarBook.Application.Features.Mediator.Command.FooterAddressCommands;
using UdemyCarBook.Application.Features.Mediator.Quaries.FooterAddressQueries;

namespace UdemyCarBook.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FooterAddressController : ControllerBase
    {
        private readonly IMediator _mediator;

        public FooterAddressController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<IActionResult> FooterAddressList()
        {
            var result = await _mediator.Send(new GetFooterAddressQuery());
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> CreateFooterAddress(CreateFooterAddressCommand command)
        {
            await _mediator.Send(command);
            return Ok("Alt adres bilgisi eklendi");
        }
        [HttpGet("GetById")]
        public async Task<IActionResult> GetFooterAddress(int id)
        {
            var vv=await _mediator.Send(new GetFooterAddressByIdQuery(id));
            return Ok(vv);
        }
        [HttpDelete]
        public async Task<IActionResult> RemoveFooterAddress(int id)
        {
            await _mediator.Send(new RemoveFooterAddressCommand(id));
            return Ok("Alt Adres Bilgisi Silindi");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateFooterAddress(UpdateFooterAddressCommand command)
        {
            await _mediator.Send(command);
            return Ok("Alt Adres Bilgisi Güncellendi");
        }

    }
}
