using System.Net;
using ApiSubastasEntity.Modelos.Atributos;
using ApiSubastasEntity.Modelos.Error.Tipo;

namespace ApiSubastasEntity.Modelos.Error
{
    public abstract class ErrorResponse
    {
        public abstract HttpStatusCode Code { get; set; }
        public abstract string Error { get; set; }

        public enum TypeError
        {
            [ErrorType(typeof(InvalidPasswordErrorDTO))]
            InvalidPassword,
            [ErrorType(typeof(ExiteUserErrorDTO))]
            ExiteUser
        }

    }
}
