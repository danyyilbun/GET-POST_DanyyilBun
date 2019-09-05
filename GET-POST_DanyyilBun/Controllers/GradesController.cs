using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GET_POST_DanyyilBun.Controllers
{
    public class GradesController : Controller
    {
        // GET: Grades
        [HttpGet]
        public ActionResult Grades()
        {
            ViewBag.Entries = 3;
            return View();
        }

        [HttpPost]
        public ActionResult Grades(FormCollection myForm)
        {
            //Double myNum;
            //foreach (var x in myForm)
            //{
            //     if (Double.TryParse(x, out myNum))
                
               
            //}
            Double one,two,three;
            Double.TryParse(myForm["grade0"], out one);
            Double.TryParse(myForm["grade1"], out two);
            Double.TryParse(myForm["grade2"], out three);
            var total = (one + two + three)/3;
            if (total >= 90)
            { ViewBag.Letter = "A"; }
            else if (total >= 80)
            { ViewBag.Letter = "B"; }
            else if (total >= 70)
            { ViewBag.Letter = "C"; }
            else if (total >= 60)
            { ViewBag.Letter = "D"; }
            else
            { ViewBag.Letter = "F"; }
            ViewBag.Total = total;
            ViewBag.Entries = 3;
            return View();
        }
    }
}