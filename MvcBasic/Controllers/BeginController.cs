using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcBasic.Controllers
{
    public class BeginController : Controller
    {
        // GET: Begin4
        public ActionResult Index()
        {
            return Content("こんにちは、世界！");
        }
        
        public ActionResult Show()
        {
            ViewBag.Message = "こんにちは、世界！!";
            return View();
        }
    }
}