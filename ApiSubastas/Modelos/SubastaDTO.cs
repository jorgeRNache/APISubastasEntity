using ApiSubastasEntity.Modelos.Atributos;
using ApiSubastasEntity.Modelos.Base;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiSubastasEntity.Modelos
{
    public class SubastaDTO : ModelosControl
    {
        public enum prop
        {
            subastaid,
            nombre_subasta,
        }

        [Key]
        [SwaggerParameter(Description = "ID de la subasta")]
        public long subastaid { get; set; }

        public string? nombre_subasta { get; set; }

        //esto es de donde se saca la subasta o una url identificativa de cada uno
        public string? url { get; set; }



    }
}
