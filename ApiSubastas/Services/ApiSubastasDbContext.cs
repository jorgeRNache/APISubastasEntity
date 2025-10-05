using ApiSubastasEntity.Modelos;
using Microsoft.EntityFrameworkCore;

namespace ApiSubastasEntity.Services
{
    public class ApiSubastasDbContext : DbContext
    {

        
        public ApiSubastasDbContext(DbContextOptions<ApiSubastasDbContext> options)
           : base(options) 
        {
          
        }

        public DbSet<FamiliaDTO> Familia { get; set; } = null!;
        public DbSet<GeneroDTO> Genero { get; set; } = null!;
        public DbSet<LoginDTO> Login { get; set; } = null!;
        public DbSet<SubastaDetalleDTO> SubastaDetalle { get; set; } = null!;
        public DbSet<SubastaDTO> Subasta { get; set; } = null!;

       
         
    }
}
