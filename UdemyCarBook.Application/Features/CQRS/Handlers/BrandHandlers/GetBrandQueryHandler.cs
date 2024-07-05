using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarBook.Application.Features.CQRS.Result.BannerResults;
using UdemyCarBook.Application.Features.CQRS.Result.BrandResults;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.CQRS.Handlers.BrandHandlers
{
    public class GetBrandQueryHandler
    {
        private readonly IRepository<Brand> _repository;
        private readonly IMapper _mapper;

        public GetBrandQueryHandler(IRepository<Brand> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<List<GetBrandQueryResult>> Handle()
        {
            var values = await _repository.GetAllAsync();
            var result= _mapper.Map<List<GetBrandQueryResult>>(values);
            return result;
        }
    }
}
