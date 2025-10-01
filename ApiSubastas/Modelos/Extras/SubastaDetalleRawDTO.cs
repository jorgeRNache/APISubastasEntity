using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApiSubastasEntity.Modelos.Atributos;
using ApiSubastasEntity.Modelos.Base;

namespace ApiSubastasEntity.Modelos.Extras
{
    public class SubastaDetalleRawDTO : ModelosControl
    {
        public enum prop
        {
            subastadetalleid,
            subastaid,
            fecha,
            nombre_genero,
            nombre_familia,
            corte1,
            corte2,
            corte3,
            corte4,
            corte5,
            corte6,
            corte7,
            corte8,
            corte9,
            corte10

        }

        public long subastadetalleid { get; set; }
        public long subastaid { get; set; }
        public DateTime fecha { get; set; }
        public string? nombre_genero { get; set; }
        public string? nombre_familia { get; set; }
        public decimal corte1 { get; set; }
        public decimal corte2 { get; set; }
        public decimal corte3 { get; set; }
        public decimal corte4 { get; set; }
        public decimal corte5 { get; set; }
        public decimal corte6 { get; set; }
        public decimal corte7 { get; set; }
        public decimal corte8 { get; set; }
        public decimal corte9 { get; set; }
        public decimal corte10 { get; set; }
        public decimal corte11 { get; set; }
        public decimal corte12 { get; set; }
        public decimal corte13 { get; set; }
        public decimal corte14 { get; set; }
        public decimal corte15 { get; set; }
    }
}
