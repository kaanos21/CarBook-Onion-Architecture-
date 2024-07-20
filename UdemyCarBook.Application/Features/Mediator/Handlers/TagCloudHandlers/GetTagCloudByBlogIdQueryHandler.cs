using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarBook.Application.Features.Mediator.Quaries.TagCloudQueries;
using UdemyCarBook.Application.Features.Mediator.Results.TagCloudResults;
using UdemyCarBook.Application.Interfaces.TagCloudInterfaces;

namespace UdemyCarBook.Application.Features.Mediator.Handlers.TagCloudHandlers
{
    public class GetTagCloudByBlogIdQueryHandler : IRequestHandler<GetTagCloudByBlogIdQuery, List<GetTagCloudByBlogIdQueryResult>>
    {
        private readonly IMapper _mapper;
        private readonly ITagCloudRepository _repository;

        public GetTagCloudByBlogIdQueryHandler(IMapper mapper, ITagCloudRepository repository)
        {
            _mapper = mapper;
            _repository = repository;
        }
        
        public async Task<List<GetTagCloudByBlogIdQueryResult>> Handle(GetTagCloudByBlogIdQuery request, CancellationToken cancellationToken)
        {
            var values = _repository.GetTagCloudsByBlogID(request.Id).ToList();
            return values.Select(x=> new GetTagCloudByBlogIdQueryResult
            {
                Title = x.Title,
                TagCloudId = x.TagCloudId,
                BlogId = x.BlogId
            }).ToList();
        }
    }
}
