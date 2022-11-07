using Despensa.BD.Datos;
using Despensa.BD.Datos.Entidades;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Despensa.Server.Controllers
{
    [ApiController]
    [Route("api/Empleados")]
    public class EmpleadosController : ControllerBase
    {
        private readonly AplicacionDbContext context;
        public EmpleadosController(AplicacionDbContext Context)
        {
            this.context = Context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Empleado>>> Get()
        {
            var respuesta = await context.Empleados.ToListAsync();

            return respuesta;
        }

        [HttpPost]

        public async Task<ActionResult<int>> Post(Empleado empleado)
        {
            try
            {
                context.Add(empleado);
                await context.SaveChangesAsync();
                return empleado.Id;
            }
            catch (Exception e)
            {
                return BadRequest($"No se pudo agregar el empleado por: {e.Message}");
            }
        }


        [HttpPut]

        public ActionResult Put(int id, [FromBody] Empleado empleado)
        {

            if (id != empleado.Id)
            {
                return BadRequest("No se encontro el registro");
            }


            var registro = context.Empleados.Where(x => x.Id == id).FirstOrDefault();


            if (registro is null)
            {
                return NotFound("No existe el empleado a modificar");
            }


            registro.Nombre = empleado.Nombre;
            registro.Apellido = empleado.Apellido;
            registro.FechaNacimiento = empleado.FechaNacimiento;
            registro.NumeroTelefono = empleado.NumeroTelefono;
            

            try
            {

                context.Empleados.Update(registro);
                context.SaveChanges();
                return Ok();

            }
            catch (Exception e)
            {
                return BadRequest($"No se pudo actualizar el empleado por: {e.Message}");
            }
        }

        [HttpDelete]

        public ActionResult Delete(int id)
        {
            var registro = context.Empleados.Where(x => x.Id == id).FirstOrDefault();

            if (registro is null)
            {
                return NotFound($"El registro {id} no fue encontrado");
            }


            try
            {
                context.Remove(registro);
                context.SaveChanges();
                return Ok($"El empleado: {registro.Nombre} ha sido eliminado");
            }
            catch (Exception e)
            {

                return BadRequest($"El empleado no pudo eliminarse por: {e.Message}");

            }
        }

        [HttpGet("id:int")]

        public async Task<ActionResult<Empleado>> GetBuscar(int id)
        {

            var empleado = await context.Empleados.
                Where(x => x.Id == id).
                Include(x =>x.Producto).
                FirstOrDefaultAsync();

            if (empleado is null)
            {
                return NotFound($"No se encontro el empleado de Id: {id}");
            }

            return empleado;


        }

    }
}
