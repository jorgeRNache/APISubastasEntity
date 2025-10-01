using System.Globalization;

namespace ApiSubastasEntity.Utilidades.Middleware
{
    public class MiddlewareDateTimeFilter
    {
        private readonly RequestDelegate _next;

        public MiddlewareDateTimeFilter(RequestDelegate next)
        {
            _next = next;
        }

        /// <summary>
        /// este filto lo estoy haciendo ya que la api tiene formato americano y si en un date time pones
        /// 04-09-2025 a pasarlo a date time te va a ppner 09-04-2025 asi con esto lo que hace es darle la vuelta para que
        /// en el datetime que te entre dentro del endpoint este en el formato correcto
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public async Task InvokeAsync(HttpContext context)
        {

            var endpoint = context.GetEndpoint();
            if (endpoint != null)
            {
                try
                {
                    var parametrosEndpoint = (endpoint as RouteEndpoint)?.RoutePattern?.Parameters;

                    foreach (var parametro in parametrosEndpoint)
                    {

                        if (parametro.ParameterPolicies[0]?.Content.ToLower() == "datetime")
                        {
                            if (DateTime.TryParse(context.Request.RouteValues[parametro.Name]?.ToString(), out DateTime fecha))
                            {
                                context.Request.RouteValues[parametro.Name] = fecha.ToString("MM-dd-yyyy");
                            }
                            else
                            {
                                context.Response.StatusCode = 400;
                                await context.Response.WriteAsync("La fecha en la URL es inválida. Use formato dd-MM-yyyy.");
                                return;
                            }

                        }
                    }
                }
                catch (Exception e)
                {
                    Comunicaciones.Instancia.EnviarEmail("Fallo en el middelware " + endpoint.DisplayName + " error = "+e.Message);
                }

            }

           
            await _next(context);
        }
    }
}
