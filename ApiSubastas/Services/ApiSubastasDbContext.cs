using ApiSubastasEntity.Modelos;
using Microsoft.EntityFrameworkCore;

namespace ApiSubastasEntity.Services
{
    public class ApiSubastasDbContext : DbContext
    {

        public string _key;
        public string _Issuer;
        public string _Audience;

        public ApiSubastasDbContext(DbContextOptions<ApiSubastasDbContext> options, IConfiguration _config)
           : base(options) 
        {
            _key = _config["Jwt:Key"];
            _Issuer = _config["Jwt:Issuer"];
            _Audience = _config["Jwt:Audience"];

        }

        public DbSet<FamiliaDTO> Familia { get; set; } = null!;
        public DbSet<GeneroDTO> Genero { get; set; } = null!;
        public DbSet<LoginDTO> Login { get; set; } = null!;
        public DbSet<SubastaDetalleDTO> SubastaDetalle { get; set; } = null!;
        public DbSet<SubastaDTO> Subasta { get; set; } = null!;

       
         
    }
}
