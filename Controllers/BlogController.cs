using System;

using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using static System.Console;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MvcTestApp.Controllers
{
    public class BlogController : Controller
    {


        // GET: /<controller>/
        public IActionResult Index()
        {
            var list = new string[] {"first blog","second blog","third blog","fourth blog","fifth blog"};
           
            ViewBag.List = list;
            return View();
        }
        public IActionResult Show()
        {
           
            var str = "you are at the blog show";
            ViewBag.show = str;
            
            return View();
        }
        public string List()
        {
            return "blah blah blah";
        }
    }
}
