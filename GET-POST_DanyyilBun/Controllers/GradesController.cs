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
            Double myNum;
            var keys = myForm.Keys;
            Double total = 0;
            Int32 i = 0;
            foreach (var x in keys)
            {
                if (x.ToString().Contains("grade"))
                {
                    Double.TryParse(myForm[x.ToString()], out myNum);
                    ViewData[x.ToString()] = myNum ;
                    
                    total += myNum;
                    i++;
                }
            }
             total = total / i;
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
            ViewBag.Total = Convert.ToDecimal(total).ToString("F"); ;

            int ammountOfEntries;
            int.TryParse(myForm["ViewBG"], out ammountOfEntries);
            ViewBag.Entries = ammountOfEntries;



            return View();
        }
    }
}