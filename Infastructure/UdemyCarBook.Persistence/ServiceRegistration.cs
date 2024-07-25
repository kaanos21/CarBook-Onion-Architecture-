using Microsoft.Extensions.DependencyInjection;
using UdemyCarBook.Application.Interfaces.CarInterfaces;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Application.Services;
using UdemyCarBook.Persistence.Repositories.CarRepositories;
using UdemyCarBook.Persistence.Repositories;
using UdemyCarBook.Persistence.Context;
using UdemyCarBook.Application.Interfaces.BlogInterfaces;
using UdemyCarBook.Persistence.Repositories.BlogRepositories;
using UdemyCarBook.Application.Interfaces.CarPricingInterfaces;
using UdemyCarBook.Persistence.Repositories.CarPricingRepositories;
using UdemyCarBook.Application.Interfaces.TagCloudInterfaces;
using UdemyCarBook.Persistence.Repositories.TagCloudRepositories;
using UdemyCarBook.Application.Features.RepositoryPattern;
using UdemyCarBook.Persistence.Repositories.CommentRepositories;
using UdemyCarBook.Application.Interfaces.StatisticsInterfaces;
using UdemyCarBook.Persistence.Repositories.StatisticsRepositories;

namespace UdemyCarBook.Persistence
{
    public static class ServicesRegistiration
    {
        public static void AddPersistenceService(this IServiceCollection services)
        {
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddScoped(typeof(ICarRepository), typeof(CarRepository));
            services.AddScoped(typeof(IBlogRepository), typeof(BlogRepository));
            services.AddScoped(typeof(ICarPricingRepository), typeof(CarPricingRepository));
            services.AddScoped(typeof(ITagCloudRepository), typeof(TagCloudRepository));
            services.AddScoped(typeof(IGenericRepository<>), typeof(CommentRepository<>));
            services.AddScoped(typeof(IStatisticsRepository), typeof(StatisticsRepository));
            services.AddScoped<CarBookContext>();

            services.AddApplicationService();

        }
    }
}
