using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaGestion_final.Models;
using SistemaGestion_final.Repository;

namespace SistemaGestion_final.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductSaleController1 : ControllerBase
    {
        [HttpGet("{idUsuario}")]
        public List<Product> GetSaleProducts(long idUsuario)
        {
            return ProductSaleHandler.GetSaleProducts(idUsuario);
        }
    }
}
