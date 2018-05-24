using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApp.Models;
using WebApp.Data;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        public Context context;

        public HomeController(Context c)
        {
            context = c;
        }

        public IActionResult Index()
        {
            var names = new string[]
            {
                "Lada", "Maman", "Vanek"
            };
            ViewBag.Names = names;
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpPost]
        public IActionResult Index(Contact Name) 
        {
            //Name.Name = "gsdgsd";
            //Name.Age = -1;
            context.ContactBase.Add(new Contact() {Name = Name.Name, Age = Name.Age });
            context.SaveChanges();
            ViewBag.Names = context.ContactBase.ToList();
            return RedirectToAction("Index");
        }
        
    }
    
}
