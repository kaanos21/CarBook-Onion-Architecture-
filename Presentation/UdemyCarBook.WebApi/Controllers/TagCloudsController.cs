using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.InteropServices;
using UdemyCarBook.Application.Features.Mediator.Command.TagCloudCommands;
using UdemyCarBook.Application.Features.Mediator.Quaries.TagCloudQueries;

namespace UdemyCarBook.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TagCloudsController : Controller
    {
        private readonly IMediator _mediator;

        public TagCloudsController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<IActionResult> TagCloudList()
        {
            var vv = await _mediator.Send(new GetTagCloudQuery());
            return Ok(vv);
        }
        [HttpGet("GetById")]
        public async Task<IActionResult> GetTagCloud(int id)
        {
            var value = await _mediator.Send(new GetTagCloudByIdQuery(id));
            return Ok(value);
        }
        [HttpPost]
        public async Task<IActionResult> CreateTagCloud(CreateTagCloudCommand command)
        {
            await _mediator.Send(command);
            return Ok("Özellikle başarıyla eklendi");
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteTagCloud(int id)
        {
            await _mediator.Send(new RemoveTagCloudCommand(id));
            return Ok("Özellik başarıyla silindi");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateTagCloud(UpdateTagCloudCommand command)
        {
            await _mediator.Send(command);
            return Ok("Özellik Başarıyla Güncellendi");
        }
        [HttpGet("GetTagCloudByBlogId")]
        public async Task<IActionResult> GetTagByBlogId(int id)
        {
           var vv= await _mediator.Send(new GetTagCloudByBlogIdQuery(id));
            return Ok(vv);
        }
    }
}
