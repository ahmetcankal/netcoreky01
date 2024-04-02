using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
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
            ViewBag.Products=db.Products.ToList();
                  
              ViewBag.kategoriler= new SelectList(db.Categories, "CategoryId", "CategoryName");
        ViewBag.tedarikciler= new SelectList(db.Suppliers, "SupplierId", "CompanyName");
            return View();
        }
    [HttpPost]
        public IActionResult List(Product aranan)
        {
           
            ViewBag.Products=db.Products.Where(x=>x.ProductName.Contains(aranan.ProductName)).ToList();
                  
              ViewBag.kategoriler= new SelectList(db.Categories, "CategoryId", "CategoryName");
        ViewBag.tedarikciler= new SelectList(db.Suppliers, "SupplierId", "CompanyName");
            return View();
        }





public IActionResult KataGoreListe(int? id)
{
    var kategorelist=db.Products.Where(x=>x.CategoryId==id).ToList();
    // TODO: Your code here
    return View(kategorelist);
}


         public IActionResult Create()
        {
      
              ViewBag.kategoriler= new SelectList(db.Categories, "CategoryId", "CategoryName");
        ViewBag.tedarikciler= new SelectList(db.Suppliers, "SupplierId", "CompanyName");
       
            return View();
        }

      
        [HttpPost]
         public IActionResult Create(Product frmgelen)
            {
                if (ModelState.IsValid)
                {
                    db.Products.Add(frmgelen);
                    db.SaveChanges();
                    return Redirect("/Home/Index");
                    
                }
              ViewBag.kategoriler= new SelectList(db.Categories, "CategoryId", "CategoryName");
            ViewBag.tedarikciler= new SelectList(db.Suppliers, "SupplierId", "CompanyName");
       
            return View();
        }





           public IActionResult Delete()
        {
            return View();
        }
    }
}