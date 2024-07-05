using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarBook.Application.Features.CQRS.Quaries.BrandQuaries;
using UdemyCarBook.Application.Features.CQRS.Quaries.CarQuaries;
using UdemyCarBook.Application.Features.CQRS.Result.BrandResults;
using UdemyCarBook.Application.Features.CQRS.Result.CarResults;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.CQRS.Handlers.CarHandlers
{
    public class GetCarByIdQueryHandler
    {
        private readonly IRepository<Car> _repository;
        private readonly IMapper _mapper;

        public GetCarByIdQueryHandler(IRepository<Car> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<GetCarByIdQueryResult> Handle(GetCarByIdQuery query)
        {
            var x = await _repository.GetByIdAsync(query.Id);
            var result= _mapper.Map<GetCarByIdQueryResult>(x);
            return result;
            
        }
    }
}
