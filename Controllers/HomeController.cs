using AssignMent1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace AssignMent1.Controllers
{
    public class HomeController : Controller
    {
        int num;
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ftoc()
        {
            return View();
        }
        [HttpPost]
        public ActionResult ftoc(boxingunboxing box)
        {
            ViewBag.ToC = (box.tempF - 32) * 5 / 9;
            ViewBag.ToF = (box.tempC * 9 / 5) + 32;
            return View();
        }
        public ActionResult poly()
        {
            return View();
        }
        [HttpPost]
        public ActionResult poly(boxingunboxing box)
        { 
            if ( box.radious == 0 ) {  ViewBag.Area = polymorph(); }
            else
            {
                ViewBag.Area = polymorph(box);
            }
            return View();
        }
        public string polymorph()
        {
            return "This is Polymorph method with out any parameter";
        }
        public string polymorph(boxingunboxing box)
        {
            return (3.14 * box.radious * box.radious).ToString();
        }
        public ActionResult stringOps()
        {
            return View();
        }
        [HttpPost]
        public ActionResult stringOps(boxingunboxing box)
        {
            ViewBag.ToLower = box.firstName.ToLower();
            ViewBag.toUpper = box.lastName.ToUpper();
            ViewBag.fullName = box.firstName + box.lastName;
            return View();
        }


        public ActionResult boxingunboxing()
        {            
            return View();
        }
        [HttpPost]
        public ActionResult boxingunboxing(boxingunboxing boxingunboxing)
        {

            num = boxingunboxing.num;                                  
            ViewBag.TypeVarNum = num.GetType();
            object obj = convertTobox();
            ViewBag.TypeVarobj = obj.GetType();
            ModelState.Clear();

            return View();
        }
        public object convertTobox()
        {  // boxing
            object obj = num;
            
            return obj;
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}