using ApiSubastasEntity.Modelos;
using ApiSubastasEntity.Utilidades;
using APISubastasEntity.Controllers.Base;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ApiSubastasEntity.Controllers
{
    public class GeneroController : BaseControlador
    {


        public GeneroController()
        {
        }


        public async Task<ActionResult<List<GeneroDTO>>> Get()
        {
             return Ok(await _context.Genero.ToListAsync());
        }

        public async Task<ActionResult> ComprobarGenero(string nombre_genero)
        {

            long generoid = 0;
            List<GeneroDTO>? listGeneros = (await Get()).Result();

            if (listGeneros is not null)
            {

                GeneroDTO? generoBD = listGeneros.FirstOrDefault(p => p.nombre_genero == nombre_genero);

                generoid = generoBD is not null ? generoBD.generoid : 0;

            }

            if (generoid == 0)
                generoid = (await Post(nombre_genero)).Result<long>();

            if (generoid == 0)
                return BadRequest();

            return Ok(generoid);

        }

        public async Task<ActionResult> Post(string genero)
        {
            GeneroDTO generoDTO = new GeneroDTO() { nombre_genero = genero };

            await _context.Genero.AddAsync(generoDTO);
            await _context.SaveChangesAsync();

            return Ok(generoDTO.generoid);
        }


    }
}
