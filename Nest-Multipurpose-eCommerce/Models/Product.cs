using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Nest_Multipurpose_eCommerce.Models
{
    public class Product
    {
        public int Id { get; set; }
        [StringLength(255)]
        public string Name { get; set; }
        public double Price { get; set; }
        public double OldPrice { get; set; }
        [StringLength(50)]
        public string Badge { get; set; }
        [StringLength(50)]
        public string BadgeText { get; set; }
        [StringLength(50)]
        public string StockStatus { get; set; }
        [StringLength(50)]
        public string StockStatusText { get; set; }
        [StringLength(1000)]
        public string ShortDescription { get; set; }
        public int Count { get; set; }
        [StringLength(1000)]
        public string Image { get; set; }
        [StringLength(1000)]
        public string HoverImage { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public int OwnerId { get; set; }
        public Owner Owner { get; set; }
    }
}
