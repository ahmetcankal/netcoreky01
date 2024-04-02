using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using nw02.Models;

namespace nw02.ViewComponents
{
   
    public class KategoriListViewComponent : ViewComponent
    {
        DbnwindContext db=new DbnwindContext();
        public IViewComponentResult Invoke()
        {
            var cat=db.Categories.ToList();

            return View(cat);
        }
        
    }
}