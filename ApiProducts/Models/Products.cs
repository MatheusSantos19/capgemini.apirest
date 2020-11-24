using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiProducts.Models
{
    public class Products
    {
        public int Code { get; set; }
        public string Description { get; set; }
        public int Stock { get; set; }

        public Products(int code, string description, int stock)
        {
            Code = code;
            Description = description;
            Stock = stock;
        }
        public Products() { 
            
        }


    }
}
