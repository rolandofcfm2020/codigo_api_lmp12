using ApiLMP12.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiLMP12.Backend
{
    public class ProductSC
    {

        public List<ProductDTO> getAllProducts()
        {
            var response = new List<ProductDTO>();
            response.Add(new ProductDTO() {Id = 1,  Title = "Coca cola lata", Cost = 10, Description = "Coca cola en lata 355ml" });
            response.Add(new ProductDTO() { Id = 2, Title = "Pepsi lata", Cost = 8, Description = "Pepsi en lata 355ml" });
            response.Add(new ProductDTO() { Id = 3, Title = "Snicker", Cost = 8, Description = "15" });
            return response;
        }

    }
}
