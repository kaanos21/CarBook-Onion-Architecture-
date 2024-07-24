using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace UdemyCarBook.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/AdminStatistics")]
    public class AdminStatisticsController : Controller
    {
        private readonly IMediator
        [Route("Index")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
