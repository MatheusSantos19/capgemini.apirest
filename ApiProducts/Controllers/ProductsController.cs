using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiProducts.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiProducts.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private static List<Products> list = new List<Products>();

        public ProductsController()
        {
           
            list.Add(new Products(1, "Arroz", 50));
            list.Add(new Products(2, "Feijao", 70));
            list.Add(new Products(3, "Macarrao", 80));
        }


        [HttpGet]
        public ActionResult<List<Products>> Get()
        {
            return Ok(list);

        }
        
        [HttpPost]
        public IActionResult Post([FromBody] Products products)
        {
            list.Add(products);
            return Created("Products/Post", list);
        }
        

        
        [HttpDelete("{code}")]
        public ActionResult Delete([FromQuery] int code)
        {
            list.RemoveAt(list.IndexOf(list.First(x => x.Code.Equals(code))));
            return Ok();
        }

        [HttpPut]
        public ActionResult Put([FromBody] Products products)
        {
            int id = list.IndexOf(list.First(x => x.Code.Equals(products.Code)));

            list[id].Code = products.Code;
            list[id].Description = products.Description;
            list[id].Stock = products.Stock;

            return Ok();

        }
        [HttpPatch]
        public ActionResult Patch([FromBody] Products products)
        {
            int id = list.IndexOf(list.First(x => x.Code.Equals(products.Code)));

            list[id].Code = products.Code;
            list[id].Description = products.Description;
            list[id].Stock = products.Stock;

            return Ok();

        }

    }
}
