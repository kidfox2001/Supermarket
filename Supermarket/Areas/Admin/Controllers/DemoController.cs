using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Supermarket.Areas.Admin.Controllers
{

    [Area("Admin")]
    public class DemoController : Controller
    {
        public IActionResult Index()
        {
            var r = new ContentResult();
            r.Content = "Hello , <u>World</u>. Mic @heart; Linux";
            r.ContentType = "text/plain";
 

            return r;
        }
    }
}