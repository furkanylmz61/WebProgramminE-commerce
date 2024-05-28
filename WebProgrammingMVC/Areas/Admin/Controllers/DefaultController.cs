using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebProgrammingMVC.Areas.Admin.Controllers
{
    [Area("Admin"), Authorize]
    public class DefaultController : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View();
        }
    }
}