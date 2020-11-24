using ProductRegistrationAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Collections;
namespace ProductRegistrationAPI.Controllers
{
    public class ProductsController : ApiController
    {
        private static List<Products> list = new List<Products>();
        
        
        

                   
        public List<Products> Get()
        {
            

            return list;
        }
        
        public void Post(int code,string description,int stock) 
        {
            list.Add(new Products(code,description,stock));
        }

        public void Delete(int code)
        {
            list.RemoveAt(list.IndexOf(list.First(x => x.Code.Equals(code))));
        }

        public void Put(int code, string description, int stock)
        {
            int id = list.IndexOf(list.First(x => x.Code.Equals(code)));

            list[id].Code = code;
            list[id].Description = description;
            list[id].Stock = stock;
        }
        public void Patch(int code, string description)
        {
            int id = list.IndexOf(list.First(x => x.Code.Equals(code)));

            list[id].Code = code;
            list[id].Description = description;
            
        }
    }
}
