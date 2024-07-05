using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarBook.Application.Features.CQRS.Commands.AboutCommands;
using UdemyCarBook.Application.Features.CQRS.Commands.BannerCommands;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.CQRS.Handlers.BannerHandlers
{
    public class CreateBannerCommandHandler
    {
        private readonly IMapper _mapper;
        private readonly IRepository<Banner> _repository;

        public CreateBannerCommandHandler(IMapper mapper, IRepository<Banner> repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public async Task Handle(CreateBannerCommand command)
        {
            var aboutEntity=_mapper.Map<Banner>(command);
            await _repository.CreateAsync(aboutEntity);
        }
    }
}
