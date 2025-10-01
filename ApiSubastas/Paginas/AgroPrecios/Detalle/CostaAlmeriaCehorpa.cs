using ApiSubastasEntity.Modelos;
using ApiSubastasEntity.Modelos.Extras;
using ApiSubastasEntity.Utilidades;

namespace ApiSubastasEntity.Paginas.AgroPrecios.Detalle
{
    public class CostaAlmeriaCehorpa : SubastasControl
    {
        public override PaginasControl pagina { get => new AgroPrecios(); }

        public override async Task<List<SubastaDetalleRawDTO>?> GetCortes(List<SubastaDTO> listSubasta)
        {
            return await AgroPrecios.ExtraerInformacion(GetSubasta(ValoresConstantes.subastasENUM.costa_almeria_cehorpa, listSubasta));
        }
    }
}
