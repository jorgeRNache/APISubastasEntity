using ApiSubastasEntity.Modelos;
using ApiSubastasEntity.Modelos.Extras;
using ApiSubastasEntity.Utilidades;
using APISubastasEntity.Controllers.Base;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;



namespace ApiSubastasEntity.Controllers
{
    [SwaggerTag("Extraccion")]
    public class ExtraccionDatosController : BaseControlador
    {
        SubastaDetalleController _subastaDetalleController;
        GeneroController _generoController;
        SubastaController _subastaController;

        public ExtraccionDatosController( 
            SubastaDetalleController subastaDetalleController,
            GeneroController generoController,
            SubastaController subastaController)
        {
            this._subastaDetalleController = subastaDetalleController;
            this._generoController = generoController;
            this._subastaController = subastaController;
        }


        public async Task<ActionResult> PostCompleto()
        {
            foreach(var(subastaid, pagina) in ValoresConstantes._dicSubastas)
            {
                if(!(await PostIndividual(subastaid)).checkResult())
                    return BadRequest( "Ha fallado en la extracion de datos completa en la subastaid: " + subastaid);
            }

            return Ok();
           

        }


        public async Task<ActionResult> PostIndividual(long subastaid)
        {

            try
            {
                _subastaController.SetContext(_context);
                _subastaDetalleController.SetContext(_context);

                List<SubastaDTO>? listSubasta = (await _subastaController.Get()).Result();

                if (listSubasta is null || listSubasta.Count == 0)
                    return BadRequest();


                List<SubastaDetalleRawDTO>? listSubastaDetalle = await ValoresConstantes._dicSubastas[subastaid].pagina.GetInformacion(ValoresConstantes._dicSubastas[subastaid], listSubasta!);

                if (listSubastaDetalle is null)
                    return BadRequest();

                //vamos a agrupar por subastaid, para sacar listas separadas de las diferentes subastas que puede tener listaSubastas
                //esto sobre todo es por los FH ya que tienen varias subastas en su interior el resto normalmente solo tendran una subasta
                Dictionary<long, List<SubastaDetalleRawDTO>> dicSubastas = listSubastaDetalle.GroupBy(s => s.subastaid).ToDictionary(g => g.Key, g => g.ToList());

                foreach(var (subastaidDic, listaSubastaDetalleIndi) in dicSubastas)
                {
                    //antes de introducir las subasta eliminamos por si acaso ya se han introducido antes no se dupliquen los datos
                    if (!(await _subastaDetalleController.DeleteFechaID(listaSubastaDetalleIndi[0].fecha, subastaidDic)).checkResult())
                        return BadRequest();

                    if (!await PostNormalizacionSubastas(listaSubastaDetalleIndi))
                        return BadRequest();
                }
                
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest( "No se ha podido recoger los cortes de la subastaid " + subastaid + " E: " + e.Message);
            }
            
            
        }

        /// <summary>
        /// Recorrera la lista de las subasta ademas de comprabar si las subastas que esta introduciendo han sido ya introducidas
        /// y en el caso de que se hayan introducido entonces comprueba si es igual o no, en el caso de que sean iguales entonces no hace post ni nada
        /// pero en el caso de que la neuva tenga informacion nueva entonces borrara la anterior y creara la nueva subasta detalle
        /// </summary>
        /// <param name="listSubasta"></param>
        /// <param name="conexion"></param>
        /// <returns></returns>
        private async Task<bool> PostNormalizacionSubastas(List<SubastaDetalleRawDTO>? listSubasta)
        {
            _generoController.SetContext(_context);
            _subastaDetalleController.SetContext(_context);

            foreach (SubastaDetalleRawDTO subastaDetalleRaw in listSubasta)
            {

                SubastaDetalleDTO subastaDetalleDTO = new SubastaDetalleDTO();

                subastaDetalleDTO.AutoMapper(subastaDetalleRaw);

                string nombre = ValoresConstantes.GetNombreGeneroNormalizado(subastaDetalleRaw.nombre_genero + "");

                if (string.IsNullOrEmpty(nombre))
                    nombre = subastaDetalleRaw.nombre_genero + "";

                subastaDetalleDTO.generoid = (await _generoController.ComprobarGenero(nombre)).Result<long>();

                SubastaDetalleDTO? subastaDetalleBBDD = (await _subastaDetalleController.GetSubastaDetalle(subastaDetalleDTO.subastaid, subastaDetalleDTO.generoid, subastaDetalleDTO.fecha)).Result();

                if (subastaDetalleBBDD is not null)
                {
                    if (!ComprobarSubastaDetalle(subastaDetalleDTO, subastaDetalleBBDD))
                        continue;

                    if (!(await _subastaDetalleController.DeleteID(subastaDetalleBBDD.subastadetalleid)).checkResult())
                        return false;
                }


                if (!(await _subastaDetalleController.Post(subastaDetalleDTO)).checkResult())
                    return false;


            }
            return true;
            
        }


        /// <summary>
        /// Comprueba si la subastadetalle que esta en la base de datos tiene mas o menos datos que el nuevo, en el caso de que el nuevo
        /// tenga mas cortes o los mismos que el guardado en la base de datos entonces nose hara el post del nuevo subasta detalle
        /// </summary>
        /// <param name="subastaDetalle"></param>
        /// <param name="subastaDetalleBBDD"></param>
        /// <returns></returns>
        private bool ComprobarSubastaDetalle(SubastaDetalleDTO subastaDetalle, SubastaDetalleDTO subastaDetalleBBDD)
        {
            if (subastaDetalle.corte1 > subastaDetalleBBDD.corte1 ||
                subastaDetalle.corte2 > subastaDetalleBBDD.corte2 ||
                subastaDetalle.corte3 > subastaDetalleBBDD.corte3 ||
                subastaDetalle.corte4 > subastaDetalleBBDD.corte4 ||
                subastaDetalle.corte5 > subastaDetalleBBDD.corte5 ||
                subastaDetalle.corte6 > subastaDetalleBBDD.corte6 ||
                subastaDetalle.corte7 > subastaDetalleBBDD.corte7 ||
                subastaDetalle.corte8 > subastaDetalleBBDD.corte8 ||
                subastaDetalle.corte9 > subastaDetalleBBDD.corte9 ||
                subastaDetalle.corte10 > subastaDetalleBBDD.corte10 ||
                subastaDetalle.corte11 > subastaDetalleBBDD.corte11 ||
                subastaDetalle.corte12 > subastaDetalleBBDD.corte12 ||
                subastaDetalle.corte13 > subastaDetalleBBDD.corte13 ||
                subastaDetalle.corte14 > subastaDetalleBBDD.corte14 ||
                subastaDetalle.corte15 > subastaDetalleBBDD.corte15
                )
                return true;


            return false;
        }

    }
}
