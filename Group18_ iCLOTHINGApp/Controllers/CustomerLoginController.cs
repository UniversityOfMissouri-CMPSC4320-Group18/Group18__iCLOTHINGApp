using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Group18__iCLOTHINGApp.Controllers
{
    public class CustomerLoginController : Controller
    {
        public ActionResult CustomerLoginForm()
        {
            return View();
        }
    }
}

