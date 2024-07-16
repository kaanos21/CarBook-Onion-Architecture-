using Microsoft.Extensions.DependencyInjection;
using UdemyCarBook.Application.Interfaces.CarInterfaces;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Application.Services;
using UdemyCarBook.Persistence.Repositories.CarRepositories;
using UdemyCarBook.Persistence.Repositories;
using UdemyCarBook.Persistence.Context;

namespace UdemyCarBook.Persistence
{
    public static class ServicesRegistiration
    {
        public static void AddPersistenceService(this IServiceCollection services)
        {
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddScoped(typeof(ICarRepository), typeof(CarRepository));
            services.AddScoped<CarBookContext>();

            services.AddApplicationService();

        }
    }
}
