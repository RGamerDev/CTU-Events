using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CTU_Events.Models;
using CTU_Events.Data;
using Microsoft.Extensions.Localization;

namespace CTU_Events.Controllers
{
    public class HomeController : Controller
    {
        EventsContext context;
        private readonly IStringLocalizer<HomeController> _localizer;

        public HomeController(IStringLocalizer<HomeController> localizer)
        {
            context = new EventsContext();
            _localizer = localizer;
        }

        public IActionResult Index(int id, string order, string searchstring)
        {
            ViewBag.Current = context.Events[id];
            if (!string.IsNullOrEmpty(order))
            {
                switch (order)
                {
                    case "Ascending":
                        context.Events.Sort();
                        break;
                    case "Descending":
                        context.Events.Reverse();
                        break;
                } 
            }

            return View(context.Events);
        }

        public IActionResult Language()
        {
            ViewData["Message"] = _localizer["Your application description page."];

            return View();
        }

        //public IActionResult Add(string title)
        //{
        //    context.events.Add(title);
        //    return PartialView("_FavList", events);
        //}

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
