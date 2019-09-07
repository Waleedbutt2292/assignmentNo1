using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NewTask.Models;

namespace NewTask.Controllers
{
    public class FirstController : Controller
    {
        private TableContext T = null;
        public FirstController(TableContext _T)
        {
            T = _T;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult AddNewCategory()
        {
            return View();

        }
        [HttpPost]
        public IActionResult AddNewCategory(Categories C)

        {
            T.Categories.Add(C);
            T.SaveChanges();
            return View();
        }

       public IActionResult ALLCategory()
        {
            var O=T.Categories.ToList();
            return View(O);
        }

        
    }
}