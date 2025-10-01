using ApiSubastasEntity.Controllers;
using ApiSubastasEntity.Services;
using ApiSubastasEntity.Utilidades;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;
using Swashbuckle.AspNetCore.Annotations;
using System.Data;

namespace ApiSubastasEntity.EndPoints
{

    [Route("api/extracciondatos")]
    [ApiController]
    public class ExtracionDatosEndPoint : ControllerBase
    {

        ExtraccionDatosController extraccionDatosController;
        ApiSubastasDbContext _context;

        public ExtracionDatosEndPoint(ApiSubastasDbContext context, ExtraccionDatosController extraccionDatosController)
        {
            _context = context;

            extraccionDatosController.SetContext(_context);
            this.extraccionDatosController = extraccionDatosController;
        }

        [Authorize]
        [HttpPost("subastaid/{subastaid}")] //api/extracciondatos
        [Authorize]
        [SwaggerOperation(
            Summary = "Ejecuta la extracción de datos de la subasta indicada",
            Description = "Este endpoint se encargara de ir a la subasta especificada y extraer los datos para luego guardarlos en base de datos,"+
            " se puede ejecutar cuantas veces quieras ya que siempre eliminara los datos de la subasta que estas intetando introducir asi evitamos duplicados de datos"
        )]
        public async Task<ActionResult> Post(long subastaid)
        {
            using var transaction = await _context.Database.BeginTransactionAsync();
            try
            {
                var result = await extraccionDatosController.PostIndividual(subastaid);
                await _context.SaveChangesAsync();
                await transaction.CommitAsync();
                return result;

            }
            catch (Exception)
            {
                transaction.Rollback();
                return BadRequest("No se ha podido guardar la subasta");
            }
            

        }



        [HttpPost("completo")] //api/extracciondatos
        [Authorize]
        [SwaggerOperation(
           Summary = "Ejecuta la extracción de datos de todas las subastas",
           Description = "Recorrera todas las subastas registradas en la API y guardara la informacion de todas en la base de datos"
       )]
        //[ProducesResponseType(typeof(SubastaDetalleDTO), StatusCodes.Status200OK)]
        //[ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult> Post()
        {

            using var transaction = await _context.Database.BeginTransactionAsync();
            try
            {
                var result = await extraccionDatosController.PostCompleto();
                await _context.SaveChangesAsync();
                await transaction.CommitAsync();
                return result;

            }
            catch (Exception)
            {
                transaction.Rollback();
                return BadRequest("No se ha podido guardar las subastas");
            }
        }

    }
}
