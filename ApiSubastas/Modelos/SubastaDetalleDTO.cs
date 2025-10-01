using ApiSubastasEntity.Modelos.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiSubastasEntity.Modelos
{
    public class SubastaDetalleDTO : ModelosControl
    {
        public enum prop
        {
            subastadetalleid,
            subastaid,
            fecha,
            generoid,
            corte1,
            corte2,
            corte3,
            corte4,
            corte5,
            corte6,
            corte7,
            corte8,
            corte9,
            corte10,
            corte11,
            corte12,
            corte13,
            corte14,
            corte15

        }

        [Key]
        public long subastadetalleid { get; set; }

        [ForeignKey("Subasta")]
        public long subastaid { get; set; }
        public SubastaDTO Subasta { get; set; } = null!;

        public DateTime fecha { get; set; }

        [ForeignKey("Genero")]
        public long generoid { get; set; }
        public GeneroDTO Genero { get; set; } = null!;

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


    public class SubastaDetalleDTOGeneroDTO : SubastaDetalleDTO
    {
        public string nombre_genero { get; set; }
    }
}
