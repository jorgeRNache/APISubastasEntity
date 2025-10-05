using ApiSubastasEntity.Modelos;
using ApiSubastasEntity.Modelos.Error;
using ApiSubastasEntity.Modelos.Extras;
using APISubastasEntity.Controllers.Base;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace ApiSubastasEntity.Controllers
{
    public class UserController : BaseControlador
    {

        private string _key;
        private string _Issuer;
        private string _Audience;

        public UserController(IConfiguration config)
        {
            _key = config["JwtSettings:SecretKey"] ?? "";
            _Issuer = config["JwtSettings:Issuer"] ?? "";
            _Audience = config["JwtSettings:Audience"] ?? "";
        }


        public async Task<ActionResult> Register(LoginDTO usuarioRegister)
        {

            if (!ValidacionContra(usuarioRegister.contra))
            {
                return BadRequest(ErrorResponse.TypeError.InvalidPassword);
            }

            LoginDTO? loginUsuario = await GetUser(usuarioRegister.usuario);

            if (loginUsuario is not null)
            {
                return BadRequest(ErrorResponse.TypeError.ExiteUser);
            }

            var passwordHasher = new PasswordHasher<string>();

            usuarioRegister.contra = passwordHasher.HashPassword(usuarioRegister.usuario, usuarioRegister.contra);

            _context.Login.Add(usuarioRegister);
            await _context.SaveChangesAsync();

            return Ok(usuarioRegister.loginid);

        }

       public async Task<LoginDTO?> GetUser(string user)
       {
           return await _context.Login.FirstOrDefaultAsync(u => u.usuario == user);
       }

    public async Task<ActionResult> Login(LoginDTO usuarioLogin) 
    {
        LoginDTO? loginUsuario = await GetUser(usuarioLogin.usuario);

        if(loginUsuario is null)
            return BadRequest("No se encuentra el usuario");
            

        var passwordHasher = new PasswordHasher<string>();
        var result = passwordHasher.VerifyHashedPassword(usuarioLogin.usuario, loginUsuario.contra, usuarioLogin.contra);

        if (result != PasswordVerificationResult.Success)
            return BadRequest("Usuario o Contraseña incorrecta");

        TokenDTO token = new TokenDTO()
        {
            token = GenerateToken(usuarioLogin.usuario),
            usuario = loginUsuario.usuario

        };

        return Ok(token);
            
    }



        #region Private Metohds 

        private string GenerateToken(string nombreUsuario)
        {
            var claims = new[]
               {
                    new Claim(ClaimTypes.Name, nombreUsuario),
                    new Claim(ClaimTypes.Role, "Admin"),
                    new Claim("prueba", "aqui hay una prueba de funcionamiento"),
                    new Claim("otraprueba", "jorgenache"),
                };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_key));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            // 4. Crear el token
            var token = new JwtSecurityToken(
                issuer: _Issuer,
                audience: _Audience,
                claims: claims,
                expires: DateTime.UtcNow.AddHours(1),
                signingCredentials: creds
            );

            return  new JwtSecurityTokenHandler().WriteToken(token);
        }


        private bool ValidacionContra(string? password)
        {

            if (string.IsNullOrWhiteSpace(password))
            {
                return false;
            }

            if (password.Length < 8)
                return false;

            if (!password.Any(char.IsUpper))
                return false;

            if (!password.Any(char.IsLower))
                return false;

            if (!password.Any(char.IsDigit))
                return false;

            if (!password.Any(c => "!@#$%^&*()-_=+[]{}|;:,.<>?/".Contains(c)))
                return false;

            return true;
        }


        #endregion
    }
}
