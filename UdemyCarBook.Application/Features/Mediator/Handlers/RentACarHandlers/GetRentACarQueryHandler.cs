using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarBook.Application.Features.Mediator.Quaries.RentACarQueries;
using UdemyCarBook.Application.Features.Mediator.Results.RentACarResults;
using UdemyCarBook.Application.Interfaces.RentACarInterfaces;

namespace UdemyCarBook.Application.Features.Mediator.Handlers.RentACarHandlers
{
    public class GetRentACarQueryHandler : IRequestHandler<GetRentACarQuery, List<GetRentACarQueryResult>>
    {
        private readonly IRentACarRepository _repository;
        public GetRentACarQueryHandler(IRentACarRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<GetRentACarQueryResult>> Handle(GetRentACarQuery request, CancellationToken cancellationToken)
        {
            var vv =await _repository.GetByFilterAsync(x => x.LocationId == request.LocationID && x.Avaible == true);
            var results=vv.Select(y=> new GetRentACarQueryResult
            {
                CarId = y.CarId,
                Brand=y.Car.Brand.Name,
                Model=y.Car.Model,
                CoverImageUrl=y.Car.CoverImageUrl,
            }).ToList();
            return results;
        }
    }
}
