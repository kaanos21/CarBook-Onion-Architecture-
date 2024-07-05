using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarBook.Application.Features.CQRS.Commands.AboutCommands;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.CQRS.Handlers.AboutHandlers
{
    public class CreateAboutCommandHandler
    {
        private readonly IRepository<About> _Repository;
        private readonly IMapper _mapper;

        public CreateAboutCommandHandler(IRepository<About> repository, IMapper mapper)
        {
            _Repository = repository;
            _mapper = mapper;
        }

        public async Task Handle(CreateAboutCommand command)
        {
            var aboutEntity = _mapper.Map<About>(command);
            await _Repository.CreateAsync(aboutEntity);
        }
    }
}
