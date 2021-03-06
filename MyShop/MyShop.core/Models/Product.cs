﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShop.core.Models
{
    public class Product : BaseEntity
    {
        public string Id { get; set; }

        [StringLength(20)]
        [DisplayName("Product Name")]
        public string Name { get; set; }
        public string description { get; set; }

        [Range(0, 1000)]
        public decimal price { get; set; }
        public string category { get; set; }
        public string image { get; set; }

    }
}
