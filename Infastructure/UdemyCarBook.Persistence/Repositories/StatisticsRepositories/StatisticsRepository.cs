using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarBook.Application.Interfaces.StatisticsInterfaces;
using UdemyCarBook.Persistence.Context;

namespace UdemyCarBook.Persistence.Repositories.StatisticsRepositories
{
    public class StatisticsRepository : IStatisticsRepository
    {
        private readonly CarBookContext _context;

        public StatisticsRepository(CarBookContext context)
        {
            _context = context;
        }

        public string GetBlogTitleByMaxBlogComment()
        {
            throw new NotImplementedException();
        }

        public int GetBrandCount()
        {
            var vv=_context.Brands.Count();
            return vv;
        }

        public string GetBrandNameByMaxCar()
        {
            throw new NotImplementedException();

        }

        public int GetAuthorCount()
        {
            var vv = _context.Authors.Count();
            return vv;
        }

        public decimal GetAvgRentPriceDaily()
        {
            var vv = _context.CarPricings.Where(x => x.PricingID == 4).Average(x => x.Amount);
            return vv;
        }

        public decimal GetAvgRentPriceMonthly()
        {
            var vv = _context.CarPricings.Where(x => x.PricingID == 5).Average(x => x.Amount);
            return vv;
        }

        public decimal GetAvgRentPriceWeekly()
        {
            var vv = _context.CarPricings.Where(x => x.PricingID == 7).Average(x => x.Amount);
            return vv;
        }

        public int GetBlogCount()
        {
            var vv=_context.Authors.Count();
            return vv;
        }

        public string GetCarBrandAndModelByRentPriceDailyMax()
        {
            throw new NotImplementedException();
        }

        public string GetCarBrandAndModelByRentPriceDailyMin()
        {
            throw new NotImplementedException();
        }

        public int GetCarCount()
        {
            var vv=_context.Cars.Count();
            return vv;
        }

        public int GetCarCountByFuelElectric()
        {
            var vv = _context.Cars.Where(x => x.Fuel == "Elektrik").Count();
            return vv;
        }

        public int GetCarCountByFuelGasolineOrDiesel()
        {
            var vv = _context.Cars.Where(x => x.Fuel == "Dizel" || x.Fuel == "Benzin").Count();
            return vv;
        }

        public int GetCarCountByKmSmallerThan1000()
        {
            var vv = _context.Cars.Where(x => x.Km < 1000).Count();
            return vv;
        }

        public int GetCarCountByTransmissionIsAuto()
        {
            var vv = _context.Cars.Where(x => x.Transmission == "Otomatik").Count();
            return vv;
        }

        public int GetLocationCount()
        {
            var vv=_context.Locations.Count();
            return (vv);
        }
    }
}
