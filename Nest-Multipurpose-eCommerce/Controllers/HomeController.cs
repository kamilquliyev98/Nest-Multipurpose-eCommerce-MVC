using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Nest_Multipurpose_eCommerce.DAL;
using Nest_Multipurpose_eCommerce.Models;
using Nest_Multipurpose_eCommerce.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nest_Multipurpose_eCommerce.Controllers
{
    public class HomeController : Controller
    {
        private readonly NestDbContext _context;
        public HomeController(NestDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            //List<Product> products = _context.Products.Include(c => c.Category).Include(o => o.Owner).ToList();

            HomeVM homeVM = new HomeVM 
            {
                Products = _context.Products.Include(c => c.Category).Include(o => o.Owner).ToList()
            };

            return View(homeVM);
        }
    }
}
