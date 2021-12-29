using System.Collections.Generic;
using Data_Transfer.Models;
using Data_Transfer.ViewModels;
using DataTransfer.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DataTransfer.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            #region ViewBag,ViewData,TempData
            //ViewBag.Name = "Gunel";
            //List<Students> student = new List<Students>
            //{
            //new Students { Id = 1, FullName = "Gunel Yusubova", Age = 26, Address = "Baku Azerbaijan" },
            //new Students { Id = 2, FullName = "Sabina Quliyeva", Age = 26, Address = "Baku Azerbaijan" },
            //new Students { Id = 3, FullName = "Kamran Baxshaliyev", Age = 27, Address = "Baku Azerbaijan" },
            //new Students { Id = 4, FullName = "Ayshan Abdullayeva", Age = 25, Address = "Neftchala Azerbaijan" },
            //new Students { Id = 5, FullName = "Elchin Yusubov", Age = 23, Address = "Ganja Azerbaijan" }
            //};
            //ViewBag.Students = student;
            //ViewData["stu"] = student;
            //ViewBag.Name = "Dilber";
            //ViewData["profession"] = "Advocate";
            //TempData["Age"] = 45;

            //return RedirectToAction("About");
            //return RedirectToAction(nameof(About));
            #endregion


            List<Students> student = new List<Students>
            {
            new Students { Id = 1, FullName = "Gunel Yusubova", Age = 26, Address = "Baku Azerbaijan" },
            new Students { Id = 2, FullName = "Sabina Quliyeva", Age = 26, Address = "Baku Azerbaijan" },
            new Students { Id = 3, FullName = "Kamran Baxshaliyev", Age = 27, Address = "Baku Azerbaijan" },
            new Students { Id = 4, FullName = "Ayshan Abdullayeva", Age = 25, Address = "Neftchala Azerbaijan" },
            new Students { Id = 5, FullName = "Elchin Yusubov", Age = 23, Address = "Ganja Azerbaijan" }
            };
            //var person = new Students { Id = 1, FullName = "Gunel Yusubova", Age = 26, Address = "Baku Azerbaijan" };
            //ReturnPerson person2 = new ReturnPerson();
            //person2.FullName = person.FullName;

           

            int[] arr = new int[5] { 1, 7, 21, 26, 24 };
            HomeVM homeVM = new HomeVM() { };
            
            homeVM.Students = student;
            homeVM.arr = arr;


            return View(); 

        }

        public IActionResult About()
        {
            //ViewBag.Name = "Dilber";
            //ViewData["profession"] = "Advocate";
            //TempData["Age"] = 45;

            return View();
        }
    }
    public class ReturnPerson
    {
        public string FullName { get; set; }

    }
}
