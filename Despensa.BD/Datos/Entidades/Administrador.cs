using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Despensa.BD.Datos.Entidades
{
    public class Administrador
    {
        public int Id { get; set; }

        [Required]
        public string Nombre { get; set; }

        [Required]
        public string NumeroTelefono { get; set; }

        [JsonIgnore]
        public List<Proveedor?> Proveedores { get; set; }
    }
}