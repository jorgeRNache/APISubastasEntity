using System.Net;

namespace ApiSubastasEntity.Modelos.Error.Tipo
{
    public class ExiteUserErrorDTO : ErrorResponse
    {
        public override HttpStatusCode Code { get; set; } = HttpStatusCode.Conflict;
        public override string Error { get; set; } = "Usuario ya existente";
    }
}
