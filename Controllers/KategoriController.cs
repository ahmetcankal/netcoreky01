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
   
    public class KategoriController : Controller
    {
       
       DbnwindContext db=new DbnwindContext();
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult KategoriListe()
        {
            // TODO: Your code here
            var cat=db.Categories.ToList();
            return PartialView("_menu",cat);
        }
        
        
        
    }
}