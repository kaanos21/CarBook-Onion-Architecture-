using MediatR;
using System.Collections.Generic;
using UdemyCarBook.Application.Features.Mediator.Results.LocationResults;

namespace UdemyCarBook.Application.Features.Mediator.Quaries.LocationQueries
{
    public class GetLocationQuery : IRequest<List<GetLocationQueryResult>>
    {
        // Gerekirse sorgu ile ilgili alanlar burada tanımlanabilir
    }
}