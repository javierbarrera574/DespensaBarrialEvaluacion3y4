using System.ComponentModel.DataAnnotations;

namespace Despensa.BD.Datos.Entidades
{
    public class Empleado
    {
        public int Id { get; set; }

        [Required]
        public string Nombre { get; set; }

        [Required]

        public string Apellido { get; set; }

        [Required]

        public string FechaNacimiento { get; set; }

        [Required]
        public string NumeroTelefono { get; set; }

        public List<Proveedor> Proveedores { get; set; }

        public int ProductoId { get; set; }
        public Producto Producto { get; set; }

    }
}