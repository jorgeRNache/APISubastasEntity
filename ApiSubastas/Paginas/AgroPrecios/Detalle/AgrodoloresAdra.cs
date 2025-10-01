using ApiSubastasEntity.Modelos;
using ApiSubastasEntity.Modelos.Extras;
using ApiSubastasEntity.Utilidades;

namespace ApiSubastasEntity.Paginas.AgroPrecios.Detalle
{
    public class AgrodoloresAdra : SubastasControl
    {

        public override PaginasControl pagina { get => new AgroPrecios();}

        public override async Task<List<SubastaDetalleRawDTO>?> GetCortes(List<SubastaDTO> listSubasta)
        {
            return await AgroPrecios.ExtraerInformacion(GetSubasta(ValoresConstantes.subastasENUM.agrodolores_adra, listSubasta));
        }
    }
}
