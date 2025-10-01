using ApiSubastasEntity.Modelos.Atributos;
using ApiSubastasEntity.Modelos.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiSubastasEntity.Modelos
{
    public class FamiliaDTO : ModelosControl
    {
        public enum prop
        {
            familiaid,
            nombre_familia,
            familia,

        }

        [Key]
        public long familiaid { get; set; }

        public string nombre_familia { get; set; }
    }
}
