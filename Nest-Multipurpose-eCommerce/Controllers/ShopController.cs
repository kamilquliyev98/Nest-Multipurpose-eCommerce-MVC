using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Nest_Multipurpose_eCommerce.DAL;
using Nest_Multipurpose_eCommerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nest_Multipurpose_eCommerce.Controllers
{
    public class ShopController : Controller
    {
        private readonly NestDbContext _context;
        public ShopController(NestDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<Product> products = _context.Products.Include(c => c.Category).Include(o => o.Owner).ToList();

            return View(products);
        }

        public IActionResult Product(int? id)
        {
            if (id == null) return BadRequest();

            if (!_context.Products.Any(p => p.Id == id)) return NotFound();

            Product product = _context.Products.Include(c => c.Category).FirstOrDefault(p => p.Id == id);

            return View(product);
        }
    }
}
