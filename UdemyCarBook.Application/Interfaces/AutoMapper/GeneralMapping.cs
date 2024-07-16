using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarBook.Application.Features.CQRS.Commands.AboutCommands;
using UdemyCarBook.Application.Features.CQRS.Commands.BannerCommands;
using UdemyCarBook.Application.Features.CQRS.Commands.BrandCommand;
using UdemyCarBook.Application.Features.CQRS.Commands.CarCommand;
using UdemyCarBook.Application.Features.CQRS.Commands.CategoryCommands;
using UdemyCarBook.Application.Features.CQRS.Commands.ContactCommands;
using UdemyCarBook.Application.Features.CQRS.Result.AboutResult;
using UdemyCarBook.Application.Features.CQRS.Result.BannerResults;
using UdemyCarBook.Application.Features.CQRS.Result.BrandResults;
using UdemyCarBook.Application.Features.CQRS.Result.CarResults;
using UdemyCarBook.Application.Features.CQRS.Result.CategoryResults;
using UdemyCarBook.Application.Features.CQRS.Result.ContactResults;
using UdemyCarBook.Application.Features.Mediator.Command.FeatureCommands;
using UdemyCarBook.Application.Features.Mediator.Command.FooterAddressCommands;
using UdemyCarBook.Application.Features.Mediator.Command.LocationCommands;
using UdemyCarBook.Application.Features.Mediator.Command.PricingCommands;
using UdemyCarBook.Application.Features.Mediator.Command.TestimonialCommands;
using UdemyCarBook.Application.Features.Mediator.Commands.ServiceCommands;
using UdemyCarBook.Application.Features.Mediator.Commands.SocialMediaCommands;
using UdemyCarBook.Application.Features.Mediator.Results.FeatureResults;
using UdemyCarBook.Application.Features.Mediator.Results.FooterAddressResults;
using UdemyCarBook.Application.Features.Mediator.Results.LocationResults;
using UdemyCarBook.Application.Features.Mediator.Results.PricingResults;
using UdemyCarBook.Application.Features.Mediator.Results.ServiceResults;
using UdemyCarBook.Application.Features.Mediator.Results.SocialMediaResults;
using UdemyCarBook.Application.Features.Mediator.Results.TestimonialResults;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Interfaces.AutoMapper
{
    public class GeneralMapping :Profile
    {
        public GeneralMapping() 
        {
            CreateMap<About, CreateAboutCommand>().ReverseMap(); // Yeni haritalama // CreateAboutCommand ile About arasında haritalama
            CreateMap<About, RemoveAboutCommand>().ReverseMap(); // Yeni haritalama // CreateAboutCommand ile About arasında haritalama
            CreateMap<About, UpdateAboutCommand>().ReverseMap(); // Yeni haritalama // CreateAboutCommand ile About arasında haritalama
            CreateMap<About, GetAboutQueryResult>().ReverseMap(); // Yeni haritalama // CreateAboutCommand ile About arasında haritalama
            CreateMap<About, GetAboutByIdQueryResult>().ReverseMap();

            CreateMap<Banner, CreateBannerCommand>().ReverseMap();// Yeni haritalama // CreateAboutCommand ile About arasında haritalama
            CreateMap<Banner, RemoveBannerCommand>().ReverseMap();// Yeni haritalama // CreateAboutCommand ile About arasında haritalama
            CreateMap<Banner, UpdateBannerCommand>().ReverseMap();// Yeni haritalama // CreateAboutCommand ile About arasında haritalama
            CreateMap<Banner, GetBannerByIdQueryResult>().ReverseMap();
            CreateMap<Banner, GetBannerQueryResult>().ReverseMap();

            CreateMap<Brand, CreateBrandCommand>().ReverseMap();
            CreateMap<Brand, UpdateBrandCommand>().ReverseMap();
            CreateMap<Brand, RemoveBrandCommand>().ReverseMap();
            CreateMap<Brand, GetBrandByIdQueryResult>().ReverseMap();
            CreateMap<Brand, GetBrandQueryResult>().ReverseMap();

            CreateMap<Car, CreateCarCommand>().ReverseMap();
            CreateMap<Car, RemoveCarCommand>().ReverseMap();
            CreateMap<Car, UpdateCarCommand>().ReverseMap();
            CreateMap<Car, GetCarByIdQueryResult>().ReverseMap();
            CreateMap<Car, GetCarQueryResult>().ReverseMap();
            CreateMap<Car, GetCarWithBrandQueryResult>().ReverseMap();

            CreateMap<Category, CreateCategoryCommand>().ReverseMap();
            CreateMap<Category, RemoveCategoryCommand>().ReverseMap();
            CreateMap<Category, UpdateCategoryCommand>().ReverseMap();
            CreateMap<Category, GetCategoryByIdQueryResult>().ReverseMap();
            CreateMap<Category, GetCategoryQueryResult>().ReverseMap();

            CreateMap<Contact, CreateContactCommand>().ReverseMap();
            CreateMap<Contact, RemoveContactCommand>().ReverseMap();
            CreateMap<Contact, UpdateContactCommand>().ReverseMap();
            CreateMap<Contact, GetContactByIdQueryResult>().ReverseMap();
            CreateMap<Contact, GetContactQueryResult>().ReverseMap();

            CreateMap<Feature, CreateFeatureCommand>().ReverseMap();
            CreateMap<Feature, RemoveFeatureCommand>().ReverseMap();
            CreateMap<Feature, UpdateFeatureCommand>().ReverseMap();
            CreateMap<Feature, GetFeatureByIdQueryResult>().ReverseMap();
            CreateMap<Feature, GetFeatureQueryResult>().ReverseMap();

            CreateMap<FooterAddress, CreateFooterAddressCommand>().ReverseMap();
            CreateMap<FooterAddress, RemoveFooterAddressCommand>().ReverseMap();
            CreateMap<FooterAddress, UpdateFooterAddressCommand>().ReverseMap();
            CreateMap<FooterAddress, GetFooterAddressByIdQueryResult>().ReverseMap();
            CreateMap<FooterAddress, GetFooterAddressQueryResult>().ReverseMap();

            CreateMap<Location, CreateLocationCommand>().ReverseMap();
            CreateMap<Location, RemoveLocationCommand>().ReverseMap();
            CreateMap<Location, UpdateLocationCommand>().ReverseMap();
            CreateMap<Location, GetLocationByIdQueryResult>().ReverseMap();
            CreateMap<Location, GetLocationQueryResult>().ReverseMap();

            CreateMap<Pricing, CreatePricingCommand>().ReverseMap();
            CreateMap<Pricing, RemovePricingCommand>().ReverseMap();
            CreateMap<Pricing, UpdatePricingCommand>().ReverseMap();
            CreateMap<Pricing, GetPricingByIdQueryResult>().ReverseMap();
            CreateMap<Pricing, GetPricingQueryResult>().ReverseMap();

            CreateMap<Service, CreateServiceCommand>().ReverseMap();
            CreateMap<Service, RemoveServiceCommand>().ReverseMap();
            CreateMap<Service, UpdateServiceCommand>().ReverseMap();
            CreateMap<Service, GetServiceByIdQueryResult>().ReverseMap();
            CreateMap<Service, GetServiceQueryResult>().ReverseMap();

            CreateMap<SocialMedia, CreateSocialMediaCommand>().ReverseMap();
            CreateMap<SocialMedia, RemoveSocialMediaCommand>().ReverseMap();
            CreateMap<SocialMedia, UpdateSocialMediaCommand>().ReverseMap();
            CreateMap<SocialMedia, GetSocialMediaByIdQueryResult>().ReverseMap();
            CreateMap<SocialMedia, GetSocialMediaQueryResult>().ReverseMap();

            CreateMap<Testimonial, CreateTestimonialCommand>().ReverseMap();
            CreateMap<Testimonial, RemoveTestimonialCommand>().ReverseMap();
            CreateMap<Testimonial, UpdateTestimonialCommand>().ReverseMap();
            CreateMap<Testimonial, GetTestimonialQueryResult>().ReverseMap();
            CreateMap<Testimonial, GetTestimonialByIdQueryResult>().ReverseMap();
        }
    }
}
