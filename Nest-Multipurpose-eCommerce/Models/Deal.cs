using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Nest_Multipurpose_eCommerce.Models
{
    public class Deal
    {
        public int Id { get; set; }
        [StringLength(255)]
        public string Name { get; set; }
        [StringLength(1000)]
        public string Image { get; set; }
        public DateTime Deadline { get; set; }
        public double Price { get; set; }
        public double OldPrice { get; set; }

        public int OwnerId { get; set; }
        public Owner Owner { get; set; }
    }
}
