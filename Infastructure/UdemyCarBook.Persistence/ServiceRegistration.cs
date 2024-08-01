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
using UdemyCarBook.Application.Interfaces.RentACarInterfaces;
using UdemyCarBook.Persistence.Repositories.RentACarRepository;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using UdemyCarBook.Application.Tools;
using UdemyCarBook.Application.Interfaces.AppUserInterfaces;
using UdemyCarBook.Persistence.Repositories.AppUserRepositories;

namespace UdemyCarBook.Persistence
{
    public static class ServicesRegistiration
    {
        public static void AddPersistenceService(this IServiceCollection services)
        {
            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(opt =>
            {
                opt.RequireHttpsMetadata = false;
                opt.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidAudience = JwtTokenDefaults.ValidAudience,
                    ValidIssuer = JwtTokenDefaults.ValidIssuer,
                    ClockSkew = TimeSpan.Zero,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(JwtTokenDefaults.Key)),
                    ValidateLifetime = true,
                    ValidateIssuerSigningKey = true
                };
            });
            services.AddScoped<CarBookContext>();
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddScoped(typeof(ICarRepository), typeof(CarRepository));
            services.AddScoped(typeof(IBlogRepository), typeof(BlogRepository));
            services.AddScoped(typeof(ICarPricingRepository), typeof(CarPricingRepository));
            services.AddScoped(typeof(ITagCloudRepository), typeof(TagCloudRepository));
            services.AddScoped(typeof(IGenericRepository<>), typeof(CommentRepository<>));
            services.AddScoped(typeof(IRentACarRepository), typeof(RentACarRepository));
            services.AddScoped(typeof(IStatisticsRepository), typeof(StatisticsRepository));
            services.AddScoped(typeof(IAppUserRepository), typeof(AppUserRepository));
            

            services.AddApplicationService();

        }
    }
}
