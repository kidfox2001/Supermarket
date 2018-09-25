using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.Extensions.Configuration;
using Rotativa.AspNetCore;
using Supermarket.Models;

namespace Supermarket.Controllers
{
    public class HomeController : Controller
    {
        private readonly IConfiguration config;
        private readonly IActionContextAccessor actionContext;

        public HomeController(IConfiguration config, IActionContextAccessor  actionContext)
        {
            this.config = config;
            this.actionContext = actionContext;
        }

      

        public IActionResult Index()
        {
            ViewBag.LogLevel = config["Logging:LOgLevel:Default"];
            ViewBag.MyToken = config["MyToken"];
            ViewBag.MyToken3 = config["MyToken_3"];

            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public async Task<IActionResult> Contact()
        {
            ViewData["Message"] = "Your contact page.";

            var r = new ViewAsPdf();
            r.PageSize = Rotativa.AspNetCore.Options.Size.A6;
            r.Copies = 2;
            r.IsGrayScale = true;

            var bytes = await r.BuildFile(actionContext.ActionContext);
           await System.IO.File.WriteAllBytesAsync("Contact.pdf", bytes) ;

            return r;
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
