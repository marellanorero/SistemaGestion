using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaGestion_final.Models;
using SistemaGestion_final.Repository;

namespace SistemaGestion_final.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpPost]
        public void CreateProduct(Product producto)
        {
            ProductHandler.InsertProduct(producto);
        }

        [HttpPut]
        public void UpdateProduct(Product producto)
        {
            ProductHandler.UpdateProduct(producto);
        }

        [HttpDelete("{id}")]
        public void DeleteProduct(long id)
        {
            ProductHandler.DeleteProduct(id);
        }

        [HttpGet("{id}")]
        public Product GetProduct(long id)
        {
            return ProductHandler.GetProduct(id);
        }
    }
}
