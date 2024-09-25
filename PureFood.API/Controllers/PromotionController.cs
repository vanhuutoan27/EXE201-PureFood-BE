using Microsoft.AspNetCore.Mvc;

namespace PureFood.API.Controllers
{
    public class PromotionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
