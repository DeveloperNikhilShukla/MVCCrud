using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCCrud.Controllers;
using MVCCrud.Models;

namespace MVCCrud.Controllers
{
    public class HomeController : Controller
    {
        
        public ActionResult Index()
        {
            Student _Student = new Student()
            {
                name = "nikhil Shukla",
                Collage = "MCA",
                DateOfBirth = DateTime.Now,
                email="nikhilshuklaiarmy@gmail.com",
                Mobile="9451111336"

            };
            return View();
        }
        [HttpPost]
        public ActionResult Index(Student _Student)
        {
          
            return View();
        }


        public ActionResult Edit()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Edit(Student _Student)
        {

            return View();
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

        public ActionResult CustomeHelper()
        {
            return View();
        }


        public ActionResult ViewBagandViewData()
        {

            ViewBag.Language=new List<String>{ "C", "c++", "JavaScript", "Java"};
            List<Student> _Student = new List<Student>()
            {
                new Student() {email="nikhil@gmail.com",Collage="Invertis",DateOfBirth=DateTime.Now },
                new Student() {email="nikhil@gmail.com",Collage="Invertis",DateOfBirth=DateTime.Now }
            };
            ViewBag.Student = _Student;

            ViewData["mykey"] = "this is mt key";
            ViewData["myList"] =new List<string>() { "this is mt key","hello" };

            return View();
        }
        public ActionResult ViewBagandViewData1()
        {
            TempData["myKey"] = "Data 1"; 
            

           

            return View();
        }
        public ActionResult ViewBagandViewData2()
        {

            ViewBag.MyKey = "nikhil";
            return View();
        }
    }
}