using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarBook.Application.Features.CQRS.Quaries.AboutQuaries;
using UdemyCarBook.Application.Features.CQRS.Quaries.BannerQuaries;
using UdemyCarBook.Application.Features.CQRS.Result.AboutResult;
using UdemyCarBook.Application.Features.CQRS.Result.BannerResults;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.CQRS.Handlers.BannerHandlers
{
    public class GetBannerByIdQueryHandler
    {
        private readonly IRepository<Banner> _repository;
        private readonly IMapper _mappper;

        public GetBannerByIdQueryHandler(IRepository<Banner> repository, IMapper mappper)
        {
            _repository = repository;
            _mappper = mappper;
        }

        public async Task<GetBannerByIdQueryResult> Handle(GetBannerByIdQuery query)
        {
            var aboutEntity=await _repository.GetByIdAsync(query.Id);
            var result=_mappper.Map<GetBannerByIdQueryResult>(aboutEntity);
            return result;
        }
    }
}
