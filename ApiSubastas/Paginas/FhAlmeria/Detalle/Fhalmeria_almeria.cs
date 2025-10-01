using ApiSubastasEntity.Modelos;
using ApiSubastasEntity.Modelos.Extras;
using ApiSubastasEntity.Utilidades;

namespace ApiSubastasEntity.Paginas.FhAlmeria.Detalle
{
    public class Fhalmeria_almeria : SubastasControl
    {
        public override PaginasControl pagina { get => new FhAlmeria(); }
        public override async Task<List<SubastaDetalleRawDTO>?> GetCortes(List<SubastaDTO> listSubasta)
        {
            return await FhAlmeria.ExtraerInformacion(GetSubasta(ValoresConstantes.subastasENUM.fhalmeria_almeria, listSubasta), listSubasta, true);
        }
    }
}
