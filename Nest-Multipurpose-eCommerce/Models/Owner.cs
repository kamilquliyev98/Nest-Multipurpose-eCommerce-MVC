using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nest_Multipurpose_eCommerce.Models
{
    public class Owner
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public IEnumerable<Product> Products { get; set; }
        public IEnumerable<Deal> Deals { get; set; }
    }
}
