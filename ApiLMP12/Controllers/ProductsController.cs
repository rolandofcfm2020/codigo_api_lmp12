using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiLMP12.Backend;
using ApiLMP12.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiLMP12.Controllers
{
    [Route("api/[controller]/[action]")]
    //.../api/products
    [ApiController]
    public class ProductsController : ControllerBase
    {
        [HttpGet] //Verbo REST o tipo de request
        public List<ProductDTO> getAllProducts()
        {
            return new ProductSC().getAllProducts(); 
        }

        //.../api/products/getProductById
        [HttpGet] //Verbo REST o tipo de request
        public ProductDTO getProductById(int id)
        {
            return new ProductSC().getAllProducts().Where(w=> w.Id == id).FirstOrDefault();
        }

        // /api/products/addProduct
        [HttpPost]
        public List<ProductDTO> addProduct([FromBody] ProductDTO newproduct)
        { 
            var products = new ProductSC().getAllProducts();
            products.Add(newproduct);

            return new ProductSC().getAllProducts(); 
        }
    }
}
