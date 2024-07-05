using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarBook.Application.Features.CQRS.Quaries.BannerQuaries;
using UdemyCarBook.Application.Features.CQRS.Quaries.BrandQuaries;
using UdemyCarBook.Application.Features.CQRS.Result.BannerResults;
using UdemyCarBook.Application.Features.CQRS.Result.BrandResults;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.CQRS.Handlers.BrandHandlers
{
    public class GetBrandByIdQueryHandler
    {
        private readonly IRepository<Brand> _repository;
        private readonly IMapper _mapper;

        public GetBrandByIdQueryHandler(IRepository<Brand> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<GetBrandByIdQueryResult> Handle(GetBrandByIdQuery query)
        {
            var values = await _repository.GetByIdAsync(query.Id);
            var result=_mapper.Map<GetBrandByIdQueryResult>(values);
            return result;
        }
    }
}
