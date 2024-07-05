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
    public class UpdateAboutCommandHandler
    {
        private readonly IRepository<About> _repository;
        private readonly IMapper _mapper;

        public UpdateAboutCommandHandler(IRepository<About> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task Handle(UpdateAboutCommand command)
        {
            var aboutEntity = await _repository.GetByIdAsync(command.AboutID);
            _mapper.Map(command, aboutEntity); // AutoMapper kullanarak UpdateAboutCommand'u About varlığına dönüştür
            await _repository.UpdateAsync(aboutEntity);
        }
    }
}
