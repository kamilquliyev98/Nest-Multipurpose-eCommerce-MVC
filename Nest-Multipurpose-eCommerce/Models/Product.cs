﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nest_Multipurpose_eCommerce.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public double OldPrice { get; set; }
        public string Badge { get; set; }
        public string BadgeText { get; set; }
        public int Count { get; set; }
        public string Image { get; set; }
        public string HoverImage { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public int OwnerId { get; set; }
        public Owner Owner { get; set; }
    }
}
