using ApiSubastasEntity.Modelos;
using ApiSubastasEntity.Modelos.Extras;
using ApiSubastasEntity.Utilidades;

namespace ApiSubastasEntity.Paginas.AgroPrecios.Detalle
{
    public class CostaAlmeriaRoquetas : SubastasControl
    {
        public override PaginasControl pagina { get => new AgroPrecios(); }

        public PaginasControl PaginasControl { get; set; }
        public override async Task<List<SubastaDetalleRawDTO>?> GetCortes(List<SubastaDTO> listSubasta)
        {
            return await AgroPrecios.ExtraerInformacion(GetSubasta(ValoresConstantes.subastasENUM.costa_almeria_roquetas, listSubasta));
        }
    }
}
