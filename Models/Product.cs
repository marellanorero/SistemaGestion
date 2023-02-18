namespace SistemaGestion_final.Models
{
    public class Product
    {
        private long id;
        private string? description;
        private decimal costo;
        private decimal precioVenta;
        private int stock;
        private long idUser;

        public Product()
        {
        }

        public Product(long id, string? description, decimal costo, decimal precioVenta, int stock, long idUser)
        {
            this.id = id;
            this.description = description;
            this.costo = costo;
            this.precioVenta = precioVenta;
            this.stock = stock;
            this.idUser = idUser;
        }

        public long Id { get => id; set => id = value; }
        public string Description { get => description; set => description = value; }
        public decimal Costo { get => costo; set => costo = value; }
        public decimal PrecioVenta { get => precioVenta; set => precioVenta = value; }
        public int Stock { get => stock; set => stock = value; }
        public long IdUser { get => idUser; set => idUser = value; }
    }
}