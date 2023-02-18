using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaGestion_final.Models;
using SistemaGestion_final.Repository;

namespace SistemaGestion_final.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SaleController1 : ControllerBase
    {
        [HttpPost]
        public void CrearVenta(List<Product> productos, long idUser)
        {
            SaleHandler.InsertSale(productos, idUser);
        }

        [HttpGet("{idUsuario}")]
        public List<Sale> TraerVentas(long idUsuario)
        {
            return SaleHandler.GetSales(idUsuario);
        }
    }
}
