using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nest_Multipurpose_eCommerce.DAL
{
    public class NestDbContext : DbContext
    {
        public NestDbContext(DbContextOptions<NestDbContext> options) : base(options)
        {

        }
    }
}
