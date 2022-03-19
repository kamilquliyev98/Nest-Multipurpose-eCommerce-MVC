using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nest_Multipurpose_eCommerce.Models
{
    public class Deal
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public DateTime Deadline { get; set; }
        public double Price { get; set; }
        public double OldPrice { get; set; }

        public int OwnerId { get; set; }
        public Owner Owner { get; set; }
    }
}
