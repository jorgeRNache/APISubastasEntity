using ApiSubastasEntity.Controllers;
using ApiSubastasEntity.Modelos;
using ApiSubastasEntity.Modelos.Error.Tipo;
using ApiSubastasEntity.Modelos.Extras;
using ApiSubastasEntity.Services;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace ApiSubastasEntity.EndPoints
{
    [Route("api/user")]
    [ApiController]
    public class UserEndPoint : ControllerBase
    {

        private readonly UserController _userController;
        private readonly ApiSubastasDbContext _context;

        public UserEndPoint(ApiSubastasDbContext context, UserController userController)
        {
            _context = context;

            userController.SetContext(context);
            _userController = userController;
            
        }

        [HttpPost("login")]
        [SwaggerOperation(
            Summary = "Te devuelve un token para usar la API en el caso de que el usuario sea correcto",
            Description = "Comprueba si el usuario existe y es correcto el inicio de sesion y en el caso de que sea todo correcto te devuelve un token" +
            " para que puedas usar los endpoints de la aplicacion durante un tiempo determinado"
        )]
        [ProducesResponseType(typeof(TokenDTO), StatusCodes.Status200OK)]
        public async Task<ActionResult> Login([FromBody] LoginDTO request)
        {
            try
            {
                return await _userController.Login(request);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            
        }


        [HttpPost("register")]
        [SwaggerOperation(
            Summary = "Registra al usuario que le introduzcas",
            Description = "Realiza unas comprobaciones del usuario y en el caso de que este todo correcto te envia un OK y te registra al usuario nuevo"
        )]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(InvalidPasswordErrorDTO), StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(typeof(ExiteUserErrorDTO), StatusCodes.Status409Conflict)]
        public async Task<ActionResult> Register([FromBody] LoginDTO request)
        {
            using var transaction = await _context.Database.BeginTransactionAsync();
            try
            {
                var id = await _userController.Register(request);
                await _context.SaveChangesAsync();
                await transaction.CommitAsync();
                return id;
            }
            catch (Exception)
            {
                await transaction.RollbackAsync();
                return BadRequest("No se ha podido registrar al usuario nuevo");
            }
            
        }
    }
}
