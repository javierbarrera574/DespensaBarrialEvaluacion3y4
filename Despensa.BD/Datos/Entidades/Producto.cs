using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Despensa.BD.Datos.Entidades
{
    public class Producto
    {

        public int Id { get; set; }

        [Required]
        public string NombreProducto { get; set; }

        [Required]
        public string DescripcionProducto { get; set; }

        [Required]
        public string FechaVencimiento { get; set; }


        [Required]

        public string PrecioProducto { get; set; }

        [JsonIgnore]
        public int? ProveedorId { get; set; }

        [JsonIgnore]
        public Proveedor? Proveedor { get; set; }

        [JsonIgnore]
        public int? CategoriaId { get; set; }

        [JsonIgnore]
        public Categoria? Categoria { get; set; }

        [JsonIgnore]
        public int? DepositoId { get; set; }


        [JsonIgnore]

        public Deposito? Deposito { get; set; }


    }
}