using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarBook.Application.Features.Mediator.Command.PricingCommands;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.Mediator.Handlers.PricingHandlers
{
    public class CreatePricingCommandHandler : IRequestHandler<CreatePricingCommand>
    {
        private readonly IRepository<Pricing> _repository;
        private readonly IMapper _mapper;

        public CreatePricingCommandHandler(IRepository<Pricing> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task Handle(CreatePricingCommand request, CancellationToken cancellationToken)
        {
            var result=_mapper.Map<Pricing>(request);
            await _repository.CreateAsync(result);
        }
    }
}
