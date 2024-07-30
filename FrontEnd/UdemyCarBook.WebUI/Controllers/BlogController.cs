using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using UdemyCarbook.Dto.BlogDtos;
using UdemyCarbook.Dto.CarPricingDto;

namespace UdemyCarBook.WebUI.Controllers
{
    public class BlogController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public BlogController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<IActionResult> Index()
        {

            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7132/api/Blog/GetAllBlogsWithAuthorsList");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultAllBlogsWithAuthorDto>>(jsonData);
                return View(values);
            }
            return View("dfljhnşdfkghnmşdfkjh");
        }
        public async Task<IActionResult> BlogDetail(int id)
        {
            var client= _httpClientFactory.CreateClient();
            ViewBag.blogid = id;
            var responseMessage2 = await client.GetAsync("https://localhost:7132/api/Comments/CommentCountByBlog?id=" + id);
            if (responseMessage2.IsSuccessStatusCode)
            {
                var jsonData2 = await responseMessage2.Content.ReadAsStringAsync();
                // var values2 = JsonConvert.DeserializeObject<GetBlogById>(jsonData2);
                ViewBag.CommentCount = jsonData2;
            }
            return View();
        }
    }
}
