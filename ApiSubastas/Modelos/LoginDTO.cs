using ApiSubastasEntity.Modelos.Base;
using System.ComponentModel.DataAnnotations;

namespace ApiSubastasEntity.Modelos
{
    public class LoginDTO : ModelosControl
    {

        public enum prop
        {
            loginid,
            usuario,
            contra
        }

        [Key]
        public long loginid { get; set; }

        public string usuario {  get; set; }   
        public string contra { get; set; }
    }
}
