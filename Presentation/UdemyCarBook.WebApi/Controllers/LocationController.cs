using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UdemyCarBook.Application.Features.Mediator.Command.LocationCommands;
using UdemyCarBook.Application.Features.Mediator.Quaries.LocationQueries;


namespace UdemyCarBook.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocationController : ControllerBase
    {
        private readonly IMediator _mediator;

        public LocationController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<IActionResult> LocationList()
        {
            var vv = await _mediator.Send(new GetLocationQuery());
            return Ok(vv);
        }
        [HttpGet("GetById")]
        public async Task<IActionResult> GetLocation(int id)
        {
            var value = await _mediator.Send(new GetLocationByIdQuery(id));
            return Ok(value);
        }
        [HttpPost]
        public async Task<IActionResult> CreateLocation(CreateLocationCommand command)
        {
            await _mediator.Send(command);
            return Ok("Özellikle başarıyla eklendi");
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteLocation(int id)
        {
            await _mediator.Send(new RemoveLocationCommand(id));
            return Ok("Özellik başarıyla silindi");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateLocation(UpdateLocationCommand command)
        {
            await _mediator.Send(command);
            return Ok("Özellik Başarıyla Güncellendi");
        }
    }
}
