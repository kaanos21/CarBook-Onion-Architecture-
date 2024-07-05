using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarBook.Application.Features.CQRS.Quaries.AboutQuaries;
using UdemyCarBook.Application.Features.CQRS.Result.AboutResult;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.CQRS.Handlers.AboutHandlers
{
    public class GetAboutByIdQueryHandler
    {
        private readonly IRepository<About> _repository;
        private readonly IMapper _mapper;

        public GetAboutByIdQueryHandler(IRepository<About> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<GetAboutByIdQueryResult> Handle(GetAboutByIdQuery query)
        {
            var aboutEntity = await _repository.GetByIdAsync(query.Id);
            var result = _mapper.Map<GetAboutByIdQueryResult>(aboutEntity);
            return result;
        }
    }
}
