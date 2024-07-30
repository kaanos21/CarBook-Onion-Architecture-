using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;
using UdemyCarbook.Dto.BrandDtos;
using UdemyCarbook.Dto.RentACarDtos;

namespace UdemyCarBook.WebUI.Controllers
{
    public class RentACarListController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public RentACarListController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<IActionResult> Index(int id)
        {
            //var bookpickdate = TempData["bookpickdate"];
            //var bookoffdate = TempData["bookoffdate"];
            //var timepick = TempData["timepick"];
            //var timeoff = TempData["timeoff"];
            var locationID = TempData["locationID"];

            //filterRentACarDto.locationID = int.Parse(locationID.ToString());
            //filterRentACarDto.avaible=true;
            id = int.Parse(locationID.ToString());

            //ViewBag.bookpickdate = bookpickdate;
            //ViewBag.bookoffdate = bookoffdate;
            //ViewBag.timepick = timepick;
            //ViewBag.timeoff = timeoff;
            //ViewBag.locationID = locationID;

            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"https://localhost:7132/api/RentACar/GetRentACarListByLocation?LocationID={id}&availbe=true");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<FilterRentACarDto>>(jsonData);
                return View(values);
            }
            return View("tyghghd");
        }
    }
}
