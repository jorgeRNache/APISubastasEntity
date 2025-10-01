using ApiSubastasEntity.Modelos;
using ApiSubastasEntity.Modelos.Extras;

namespace ApiSubastasEntity.Paginas
{
    public abstract class PaginasControl
    {
        public abstract Task<List<SubastaDetalleRawDTO>?> GetInformacion(SubastasControl valor, List<SubastaDTO> listSubasta);
    }

}
