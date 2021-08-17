using HomeTaskViewModel.Models;
using HomeTaskViewModel.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeTaskViewModel.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Name = "Khayal";
            ViewBag.Surname = "Binnetov";
            TempData["Age"] = 23;
            //return View();
            return RedirectToAction(nameof(Age));
        }
        
        public IActionResult Age()
        {
            return View();
        }

        public IActionResult Students()
        {
            string learn = "ASP.NET View and Model";

            List<Car> cars = new List<Car>
            {
                new Car{Id=1,Marka="Porseche",Model="Cayenne"},
                new Car{Id=2,Marka="Bmw",Model="M5"},
                new Car{Id=3,Marka="Mersedes",Model="G500"}

            };

            List<Student> students = new List<Student>
           {
               new Student{Id=1,Name="Khayal",Surname="Binnetov" },
               new Student{Id=2,Name="Murad",Surname="Binnetov" },
               new Student{Id=3,Name="Kenan",Surname="Binnetov" }
           };

            HomeViewModel model = new HomeViewModel
            {
                Students= students,
                Cars=cars,
                Learn=learn


            };

            return View(model);
        }
    }
}
