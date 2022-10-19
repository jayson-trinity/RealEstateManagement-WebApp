using Microsoft.AspNetCore.Mvc;

namespace TRINTY_ESTATES.Controllers
{
    public class AgentsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
