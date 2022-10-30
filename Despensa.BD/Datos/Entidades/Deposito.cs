using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Despensa.BD.Datos.Entidades
{
    public class Deposito
    {

        public int Id { get; set; }

        [Required]
        public string CodigoEstante { get; set; }

        [Required]
        public string CategoriaEnEstante { get; set; }

        [Required]
        public string CantidadEnEstante { get; set; }

        [Required]
        public string UnidadMinima { get; set; }

        [JsonIgnore]
        public List<Producto?> Productos { get; set; }


    }
}