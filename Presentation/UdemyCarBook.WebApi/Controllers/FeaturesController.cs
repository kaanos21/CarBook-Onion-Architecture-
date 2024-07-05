﻿using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using UdemyCarBook.Application.Features.Mediator.Command.FeatureCommands;
using UdemyCarBook.Application.Features.Mediator.Quaries.FeatureQueries;

namespace UdemyCarBook.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FeaturesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public FeaturesController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<IActionResult> FeatureList()
        {
            var vv = await _mediator.Send(new GetFeatureQuery());
            return Ok(vv);
        }
        [HttpGet("GetById")]
        public async Task<IActionResult> GetFeature(int id)
        {
            var value=await _mediator.Send(new GetFeatureByIdQuery(id));
            return Ok(value);
        }
        [HttpPost]
        public async Task<IActionResult> CreateFeature(CreateFeatureCommand command)
        {
            await _mediator.Send(command);
            return Ok("Özellikle başarıyla eklendi");
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteFeature(int id)
        {
            await _mediator.Send(new RemoveFeatureCommand(id));
            return Ok("Özellik başarıyla silindi");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateFeature(UpdateFeatureCommand command)
        {
            await _mediator.Send(command);
            return Ok("Özellik Başarıyla Güncellendi");
        }
    }
}
