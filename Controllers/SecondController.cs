using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NewTask.Models;

namespace NewTask.Controllers
{
    public class SecondController : Controller
    {
        private TableContext k = null;
        public SecondController (TableContext _post)
        {
            k = _post;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult AddPost()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddPost(Post p)
        {
            k.Post.Add(p);
            k.SaveChanges();
            return View();
        }
        public IActionResult ViewList()
        {
            var f=k.Post.ToList();
            return View(f);
        }
    }
}