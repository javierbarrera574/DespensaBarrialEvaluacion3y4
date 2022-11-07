using System.ComponentModel.DataAnnotations;


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

        
        public int ProveedorId { get; set; }

       
        public Proveedor Proveedor { get; set; }

    
        public int CategoriaId { get; set; }

     
        public Categoria Categoria { get; set; }
    }
}