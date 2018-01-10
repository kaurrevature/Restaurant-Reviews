using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YummyTummy.Models;

namespace YummyTummy.Controllers
{

    public class HomeController : Controller
    {
        Address address = new Address();
        
        public ActionResult Index()//Action Methods
        {
            ViewBag.Name = "Chik-fil-e";// C# 4.0
            ViewData["Location"] = "Reston VA";
            TempData["Country"] = "USA";
            return File();
        }
        //public string Index()
        //{
        //    return "Hello World";
        // }

        public ContentResult About()
        {
            ViewBag.Message = "Your application description page.";

            return Content("This Application gives restuarants with best reviews");
        }
        public JsonResult JsonData()
        {
            address.Street = "Plaza America";
            address.City = "Reston";
            address.State = "VA";
            address.Country = "USA";
            address.ZipCode = "20190";
            address.Phone = "XXX-XXX-XXXX";
            address.Email = "wholefoods@restonwf.com";
            return Json(address,JsonRequestBehavior.AllowGet);
        }

        public ViewResult Contact()
        {
            ViewBag.Message = "Contact Whole Foods";
            address.Street = "Plaza America";
            address.City = "Reston";
            address.State = "VA";
            address.Country = "USA";
            address.ZipCode = "20190";
            address.Phone = "XXX-XXX-XXXX";
            address.Email = "wholefoods@restonwf.com";
            return View(address);
        }
    }
}