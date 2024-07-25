using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarBook.Application.Features.CQRS.Result.BrandResults;

namespace UdemyCarBook.Application.Features.Mediator.Quaries.StatisticsQueries
{
    public class GetBrandCountQuery:IRequest<GetBrandQueryResult>
    {
    }
}
