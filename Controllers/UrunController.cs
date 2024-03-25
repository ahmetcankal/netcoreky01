using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using nw02.Models;

namespace nw02.Controllers
{
  
    public class UrunController : Controller
    {
        DbnwindContext db=new DbnwindContext();

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult List()
        {
            var result=db.Products.ToList();
            return View(result);
        }
         public IActionResult Create()
        {
          
            return View();
        }
           public IActionResult Delete()
        {
            return View();
        }
    }
}