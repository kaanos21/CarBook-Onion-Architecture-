using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarBook.Application.Features.Mediator.Results.PricingResults;

namespace UdemyCarBook.Application.Features.Mediator.Quaries.PricingQueries
{
    public class GetPricingByIdQuery:IRequest<GetPricingByIdQueryResult>
    {
        public GetPricingByIdQuery(int ıd)
        {
            Id = ıd;
        }

        public int Id { get; set; }

    }
}
