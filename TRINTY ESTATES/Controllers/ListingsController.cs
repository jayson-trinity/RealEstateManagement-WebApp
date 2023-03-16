using Microsoft.AspNetCore.Mvc;
using TRINTY_ESTATES.Models;

namespace TRINTY_ESTATES.Controllers
{
    public class ListingsController : Controller
    {
        public IActionResult Listings()
        {
            ListingsModel model = new ListingsModel();
            return View(model);
        }
    }
}
