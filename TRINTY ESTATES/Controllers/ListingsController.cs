using Microsoft.AspNetCore.Mvc;

namespace TRINTY_ESTATES.Controllers
{
    public class ListingsController : Controller
    {
        public IActionResult Listings()
        {
            return View();
        }
    }
}
