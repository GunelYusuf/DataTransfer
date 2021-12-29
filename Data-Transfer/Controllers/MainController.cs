using System.Collections.Generic;
using Data_Transfer.Models;
using Data_Transfer.ViewModels;
using Microsoft.AspNetCore.Mvc;



namespace Data_Transfer.Controllers
{
    public class MainController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            List<Employees> employee = new List<Employees>
            {
                 new Employees { Id = 1, Name = "Gunel", Age = 26, profession = "CEO" },
                 new Employees { Id = 1, Name = "Sabina", Age = 27, profession = "Manager" },
                 new Employees { Id = 1, Name = "Ayshan", Age = 25, profession = "Director" }
            };

            List<Companies> company = new List<Companies>
            {
                 new Companies { Id = 1, Name = "Edu", Address="Ganjlik" },
                 new Companies { Id = 2, Name = "Code Academy", Address="28 May" },
                 new Companies { Id = 3, Name = "Train Brain", Address="Nizami" }
            };
            MainVM mainVM = new MainVM();
            mainVM.Employees = employee;
            mainVM.company = company;
            return View(mainVM);
        }
    }
}
