using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Despensa.BD.Datos.Entidades
{
    public class Categoria
    {
        public int Id { get; set; }

        [Required]

        public string TipoCategoria { get; set; }


        [Required]

        public string CodigoCategoria { get; set; }

        [JsonIgnore]
        public Producto? Producto { get; set; }

    }
}