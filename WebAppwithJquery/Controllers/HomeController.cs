using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppwithJquery.Models;
using Newtonsoft.Json;

namespace WebAppwithJquery.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult GetStudent()
        {
            Student std = new Student()
            {
                id = 1,
                name = "Ali",
                email = "ms@gmail.com"
            };

            var json = JsonConvert.SerializeObject(std);
            return Json(json, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult AddStudent(Student student)
        {
            return Json("true", JsonRequestBehavior.AllowGet);
        }
    
    
    
    }
}