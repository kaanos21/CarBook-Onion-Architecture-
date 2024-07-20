using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UdemyCarBook.Application.Features.Mediator.Quaries.CarPricingQueries;
using UdemyCarBook.Application.Features.Mediator.Quaries.LocationQueries;

namespace UdemyCarBook.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarPricingsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CarPricingsController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<IActionResult> GetCarPricingWithCarList()
        {
            var vv = await _mediator.Send(new GetCarPricingWithCarQuery());
            return Ok(vv);
        }
    }
}
