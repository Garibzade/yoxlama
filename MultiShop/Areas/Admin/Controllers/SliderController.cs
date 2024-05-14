using Microsoft.AspNetCore.Mvc;

namespace MultiShop.Areas.Admin.Controllers
{
    [Area("admin")]
    public class SliderController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
