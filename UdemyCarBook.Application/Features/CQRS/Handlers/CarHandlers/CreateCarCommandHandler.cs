using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarBook.Application.Features.CQRS.Commands.BrandCommand;
using UdemyCarBook.Application.Features.CQRS.Commands.CarCommand;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.CQRS.Handlers.CarHandlers
{
    public class CreateCarCommandHandler
    {
        private readonly IRepository<Car> _repository;
        private readonly IMapper _mapper;

        public CreateCarCommandHandler(IRepository<Car> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task Handle(CreateCarCommand x)
        {
            var aboutEntity= _mapper.Map<Car>(x);
            await _repository.CreateAsync(aboutEntity);
        }
    }
}
