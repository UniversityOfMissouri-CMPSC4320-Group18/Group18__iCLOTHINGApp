using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Group18__iCLOTHINGApp.Controllers
{
    public class CustomerRegistrationController : Controller
    {
        public ActionResult CustomerRegisterForm()
        {
            return View();
        }
    }
}

