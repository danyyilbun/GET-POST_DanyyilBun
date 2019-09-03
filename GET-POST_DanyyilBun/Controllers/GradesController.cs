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
        public ActionResult Index(FormCollection myForm)
        {
            foreach (var x in myForm)
            {

            }
            return View();
        }
    }
}