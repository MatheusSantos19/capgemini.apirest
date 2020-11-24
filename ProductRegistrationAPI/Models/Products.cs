using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProductRegistrationAPI.Models
{

    public class Products
    {
        public int Code { get; set; }
        public string Description { get; set; }
        public int Stock { get; set; }

        public Products(int code,string description,int stock)
        {
            this.Code = code;
            Description = description;
            Stock = stock;
        }
    }
}