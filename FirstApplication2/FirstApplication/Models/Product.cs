using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FirstApplication.Models
{
    public class Product
    {
        public string Name { get; set; }
        public float Price { get; set; }
        public int Quantity { get; set; }
        public string Description { get; set; }
    }
}