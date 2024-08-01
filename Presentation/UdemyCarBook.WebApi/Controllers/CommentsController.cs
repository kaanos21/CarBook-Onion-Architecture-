using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UdemyCarBook.Application.Features.Mediator.Command.CommentCommands;
using UdemyCarBook.Application.Features.RepositoryPattern;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentsController : ControllerBase
    {
        private readonly IGenericRepository<Comment> _commentsRepository;
        private readonly IMediator _mediator;

        public CommentsController(IGenericRepository<Comment> commentsRepository, IMediator mediator)
        {
            _commentsRepository = commentsRepository;
            _mediator = mediator;
        }

        [HttpGet]
        public IActionResult CommentList()
        {
            var value = _commentsRepository.GetAll();
            return Ok(value);
        }
        [HttpDelete]
        public IActionResult RemoveComment(int id)
        {
            var vv=_commentsRepository.GetById(id);
            _commentsRepository.Remove(vv);
            return Ok();
        }
        [HttpPost]
        public IActionResult CreateComment(Comment comment)
        {
            _commentsRepository.Create(comment);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateComment(Comment comment)
        {
            _commentsRepository.Update(comment);
            return Ok();
        }
        [HttpGet("GetById")]
        public IActionResult GetComment(int id)
        {
            var vv = _commentsRepository.GetById(id);
            return Ok(vv);
        }
        [HttpGet("CommentListByBlog")]
        public IActionResult CommentListByBlog(int id)
        {
            var vv = _commentsRepository.GetCommentsByBlogId(id);
            return Ok(vv);
        }
        [HttpGet("CommentCountByBlog")]
        public ActionResult CommentCountByBlog(int id)
        {
            var value=_commentsRepository.GetCountCommentByBlog(id);
            return Ok(value);
        }
        [HttpPost("CreateCommentWithMediator")]
        public async Task<IActionResult> CreateCommentWithMediator(CreateCommentCommand command)
        {
            await _mediator.Send(command);
            return Ok("Başarı ");
        }
    }
}
