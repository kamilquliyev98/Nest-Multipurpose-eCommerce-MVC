using Microsoft.EntityFrameworkCore;
using Nest_Multipurpose_eCommerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nest_Multipurpose_eCommerce.DAL
{
    public class NestDbContext : DbContext
    {
        public NestDbContext(DbContextOptions<NestDbContext> options) : base(options) { }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
