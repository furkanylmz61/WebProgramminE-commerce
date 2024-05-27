using Microsoft.AspNetCore.Mvc;

namespace WebProgrammingMVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DefaultController : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View();
        }
    }
}