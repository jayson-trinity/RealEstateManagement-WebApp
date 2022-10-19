using Microsoft.AspNetCore.Mvc;

namespace TRINTY_ESTATES.Controllers
{
    public class RentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
