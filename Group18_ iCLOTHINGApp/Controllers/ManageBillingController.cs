using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Group18__iCLOTHINGApp.Models;

namespace Group18__iCLOTHINGApp.Controllers
{
    public class ManageBillingController : Controller
    {
        public ActionResult EmailForm()
        {
            return View();
        }
        public ActionResult SubmitEmailForm()
        {

            String subject = Request.Form["subject"];
            String body = Request.Form["body"];
            Email email = new Email
            {
                emailSubject = subject,
                emailBody = body,
                emailDate = new DateOnly(),
                emailNo = "1"
            };
            Console.WriteLine(email.toString());
            return View("EmailForm");
        }
    }
}

