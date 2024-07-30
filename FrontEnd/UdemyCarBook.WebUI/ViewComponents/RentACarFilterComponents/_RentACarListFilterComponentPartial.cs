using Microsoft.AspNetCore.Mvc;

namespace UdemyCarBook.WebUI.ViewComponents.RentACarFilterComponents
{
    public class _RentACarListFilterComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke(string v) 
        {
             v = "aa";
            TempData["value"] = v;
            return View(); 
        }
    }
}
