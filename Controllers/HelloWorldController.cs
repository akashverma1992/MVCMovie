using System;
using System.Web;
using System.Web.Mvc;

namespace MVCMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: HelloWorld

        public ActionResult Index()
        {
            //return View();
            //ActionResult ar;
            //ar = (ViewResult) new ViewResult().View;
            return View();
        }

        public ActionResult Welcome(String name, int numTimes = 1)
        {
            ViewBag.Name = name;
            ViewBag.Message = "Hello, " + name;
            ViewBag.NumTime = numTimes;
            return View();
        }
        //public String Index2()
        //{
        //    return "<b>This is default action.....</b>";
        //}

        //public String Welcome1()
        //{
        //    return "this is the <b>welcome action method.....</b>";
        //}

        //public String Welcome2(String name, int age = 0)
        //{
        //    string str = HttpUtility
        //        .HtmlEncode("Hello " + name + ", age is " + age);
        //    return str;
        //}

        public ActionResult googlePage()
        {
            return Redirect("http://www.google.co.in/");
        }
    }
}