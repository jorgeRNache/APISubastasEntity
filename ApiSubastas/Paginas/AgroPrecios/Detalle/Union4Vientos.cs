using System.Data;
using System.Text.RegularExpressions;
using ApiSubastasEntity.Modelos;
using ApiSubastasEntity.Modelos.Extras;
using ApiSubastasEntity.Utilidades;
using HtmlAgilityPack;

namespace ApiSubastasEntity.Paginas.AgroPrecios.Detalle
{
    public class Union4Vientos : SubastasControl
    {
        public override PaginasControl pagina { get => new AgroPrecios(); }

        public override async Task<List<SubastaDetalleRawDTO>?> GetCortes(List<SubastaDTO> listSubasta)
        {
            return await AgroPrecios.ExtraerInformacion(GetSubasta(ValoresConstantes.subastasENUM.union_4_vientos, listSubasta), "tab-sub" , "//li[contains(@class, 'fec')]");
        }

    }
}
