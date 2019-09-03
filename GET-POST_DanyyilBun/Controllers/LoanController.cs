using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GET_POST_DanyyilBun.Controllers
{
    public class LoanController : Controller
    {
        // GET: Loan
        [HttpGet]
        public ActionResult Loan()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Loan(Int32 years, Double rate, Double investment)
        {
            ViewData["years"] = years;
            ViewData["rate"] = rate;
            ViewData["investment"] = investment;
            for (int i = 0; i <= years; i++)
            {
                investment *= rate/100;
            }

            return View();
        }
    }
}