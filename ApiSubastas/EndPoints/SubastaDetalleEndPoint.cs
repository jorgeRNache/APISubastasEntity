using ApiSubastasEntity.Controllers;
using ApiSubastasEntity.Modelos;
using ApiSubastasEntity.Modelos.Extras;
using ApiSubastasEntity.Services;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace ApiSubastasEntity.EndPoints
{
    [Route("api/subastadetalle")]
    [ApiController]
    public class SubastaDetalleEndPoint : ControllerBase
    {
        private readonly SubastaDetalleController _subastaDetalleController;
        private readonly ApiSubastasDbContext _context;

        public SubastaDetalleEndPoint(ApiSubastasDbContext context, SubastaDetalleController subastaDetalleController)
        {
            _context = context;

            subastaDetalleController.SetContext(context);
            _subastaDetalleController = subastaDetalleController;
        }


        [HttpGet("subasta/fecha/{subastaid:long}/{fecha:DateTime}")]
        [SwaggerOperation(
           Summary = "Te devuelve los cortes de una subasta en una fecha en especifico",
           Description = "Tras una serie de comprobaciones te da si es correcto los cortes de una" +
           " subasta en la fecha correspondiente"
       )]
        [ProducesResponseType(typeof(TokenDTO), StatusCodes.Status200OK)]
        public async Task<ActionResult<List<SubastaDetalleDTO>>> GetSubastaFecha(long subastaid, DateTime fecha)
        {
            try
            {
                return await _subastaDetalleController.GetSubastaFecha(subastaid, fecha);
            }
            catch (Exception ex) 
            {
                return BadRequest("No se ha podido recoger los cortes de la subasta en la fecha especificada");
            }
        }

        [HttpGet("subasta/fecha/genero/{subastaid:long}/{fecha:DateTime}/{generoid:long}")]
        [SwaggerOperation(
          Summary = "Te devuelve los cortes de una subasta en una fecha en especifico y un genero",
          Description = "Tras una serie de comprobaciones te da si es correcto los cortes de una" +
          " subasta en la fecha correspondiente y con el genero especificado"
      )]
        [ProducesResponseType(typeof(TokenDTO), StatusCodes.Status200OK)]
        public async Task<ActionResult<List<SubastaDetalleDTO>>> GetSubastaFechaGenero(long subastaid, DateTime fecha, long generoid)
        {
            return await _subastaDetalleController.GetSubastaFechaGenero(subastaid, fecha, generoid);
        }


        [HttpGet("subasta/ultimodia/{subastaid:long}")]
        [SwaggerOperation(
          Summary = "",
          Description = ""
      )]
        [ProducesResponseType(typeof(TokenDTO), StatusCodes.Status200OK)]
        public async Task<ActionResult<List<SubastaDetalleDTO>>> GetSubastaUltimoDia(long subastaid)
        {
            try
            {
                return await _subastaDetalleController.GetUltimaSubasta(subastaid);
            }
            catch (Exception)
            {
                return BadRequest("No se ha podido obtener la informacion de las ultimas subastas");
            }
            
        }

        [HttpGet("subasta/genero/ultimodia/{subastaid:long}/{generoid:long}")]
        [SwaggerOperation(
         Summary = "",
         Description = ""
        )]
        [ProducesResponseType(typeof(TokenDTO), StatusCodes.Status200OK)]
        public async Task<ActionResult<List<SubastaDetalleDTO>>> GetSubastaUltimoDiaGenero(long subastaid, long generoid)
        {
            try
            {
                return await _subastaDetalleController.GetUltimaSubastaGenero(subastaid, generoid);
            }
            catch
            {
                return BadRequest("No se ha podido obtener la informacion de las ultimas subastas y genero");
            }
            
        }

    }
}
