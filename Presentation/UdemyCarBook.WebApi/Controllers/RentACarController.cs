using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UdemyCarBook.Application.Features.Mediator.Quaries.RentACarQueries;

namespace UdemyCarBook.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RentACarController : ControllerBase
    {
        private readonly IMediator _mediator;

        public RentACarController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet("GetRentACarListByLocation")]
        public async Task<IActionResult> GetACarListByLocation(int LocationID,bool availbe)
        {
            GetRentACarQuery getRentACarQuery = new GetRentACarQuery()
            {
                Avaible = availbe,
                LocationID = LocationID
            };
            var vv=await _mediator.Send(getRentACarQuery);
            return Ok(vv);
        }
    }
}
