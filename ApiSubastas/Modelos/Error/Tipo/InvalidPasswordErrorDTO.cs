using System.Net;

namespace ApiSubastasEntity.Modelos.Error.Tipo
{
    public class InvalidPasswordErrorDTO : ErrorResponse
    {
        public override HttpStatusCode Code { get; set; } = HttpStatusCode.Unauthorized;
        public override string Error { get; set; } = "Contraseña Incorrecta";
    }
}
