using Despensa.BD.Datos.Entidades;
using Microsoft.EntityFrameworkCore;

namespace Despensa.BD.Datos
{
	public class AplicacionDbContext : DbContext
	{
		public AplicacionDbContext(DbContextOptions options) : base(options) { }


        public DbSet<Empleado> Empleados { get; set; }

        public DbSet<Categoria> Categorias { get; set; }

        public DbSet<Producto> Productos { get; set; }

        public DbSet<Proveedor> Proveedores { get; set; }

    }

}