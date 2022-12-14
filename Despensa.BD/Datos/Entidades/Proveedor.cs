using System.ComponentModel.DataAnnotations;

namespace Despensa.BD.Datos.Entidades
{
    public class Proveedor
    {

        public int Id { get; set; }

        [Required]
        public string Nombre { get; set; }
      

        [Required]
        public string CorreoElectronico { get; set; }


        [Required]

        public string NumeroTelefono { get; set; }   
        
        public int EmpleadoId { get; set; }

        public Empleado Empleado { get; set; }


        public int ProductoId { get; set; }

        public Producto Producto { get; set; }

    }
}