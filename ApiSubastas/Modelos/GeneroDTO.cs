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
    public class GeneroDTO : ModelosControl
    {
        public enum prop
        {
            generoid,
            nombre_genero
        }

        [Key]
        public long generoid { get; set; }
        public string nombre_genero { get; set; }
    }
}
