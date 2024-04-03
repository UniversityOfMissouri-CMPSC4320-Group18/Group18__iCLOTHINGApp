using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Group18__iCLOTHINGApp.Controllers
{
    public class ProductListWindowController : Controller
    {
        public IActionResult ProductListWindow()
        {
            return View();
        }
    }
}

