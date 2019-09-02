using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CTU_Events.Models;
using CTU_Events.Data;

namespace CTU_Events.Controllers
{
    public class HomeController : Controller
    {
        EventsContext context;

        public HomeController()
        {
            context = new EventsContext();
        }

        public IActionResult Index(int id)
        {
            ViewBag.Current = context.Events[id];
            return PartialView(context.Events);
        }

        public IActionResult Language()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult _List()
        {
            return PartialView();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
