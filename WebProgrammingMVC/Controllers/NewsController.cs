using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BL;
using Microsoft.AspNetCore.Mvc;

namespace WebProgrammingMVC.Controllers
{
    public class NewsController : Controller
    {
        NewsManager newsManager = new NewsManager();
        public IActionResult Index()
        {
            return View(newsManager.GetAll());
        }
        public IActionResult Detail(int id)
        {
            return View(newsManager.Find(id));
        }
    }
}