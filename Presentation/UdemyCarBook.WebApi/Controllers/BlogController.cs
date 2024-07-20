using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UdemyCarBook.Application.Features.Mediator.Command.BlogCommand;
using UdemyCarBook.Application.Features.Mediator.Quaries.BlogQueries;

namespace UdemyCarBook.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogController : ControllerBase
    {
        private readonly IMediator _mediator;

        public BlogController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<IActionResult> BlogList()
        {
            var vv = await _mediator.Send(new GetBlogQuery());
            return Ok(vv);
        }
        [HttpGet("GetById")]
        public async Task<IActionResult> GetBlog(int id)
        {
            var value = await _mediator.Send(new GetBlogByIdQuery(id));
            return Ok(value);
        }
        [HttpPost]
        public async Task<IActionResult> CreateBlog(CreateBlogCommand command)
        {
            await _mediator.Send(command);
            return Ok("Özellikle başarıyla eklendi");
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteBlog(int id)
        {
            await _mediator.Send(new RemoveBlogCommand(id));
            return Ok("Özellik başarıyla silindi");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateBlog(UpdateBlogCommand command)
        {
            await _mediator.Send(command);
            return Ok("Özellik Başarıyla Güncellendi");
        }
        [HttpGet("GetLast3BlogsWithAuthorsList")]
        public async Task<IActionResult> GetLast3BlogsWithAuthorsList()
        {
            var vv = await _mediator.Send(new GetLast3BlogsWithAuthorsQuery());
            return Ok(vv);
        }
        [HttpGet("GetAllBlogsWithAuthorsList")]
        public async Task<IActionResult> GetAllBlogsWithAuthorsList()
        {
            var vv = await _mediator.Send(new GetAllBlogsWithAuthorQuery());
            return Ok(vv);
        }
        [HttpGet("GetBlogByAuthorId")]
        public async Task<IActionResult> GetBlogByAuthorId(int id)
        {
            var vv = await _mediator.Send(new GetBlogByAuthorIdQuery(id));
            return Ok(vv);
        }
    }
}
