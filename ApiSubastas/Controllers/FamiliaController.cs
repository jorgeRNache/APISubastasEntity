using ApiSubastasEntity.Modelos;
using ApiSubastasEntity.Utilidades;
using APISubastasEntity.Controllers.Base;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ApiSubastasEntity.Controllers
{
    public class FamiliaController : BaseControlador
    {
        public FamiliaController()
        {
        }


        public async Task<ActionResult<List<FamiliaDTO>>> Get()
        {
            var resultado = await _context.Familia.ToListAsync();
            return Ok(resultado);
        }

        public async Task<ActionResult> ComprobarFamila(string nombre_familia)
        {

            long familiaid = 0;

            List<FamiliaDTO>? listFamiliar = (await Get()).Result();

            if (listFamiliar is not null)
            {

                FamiliaDTO? familiaBD = listFamiliar.FirstOrDefault(p => p.nombre_familia == nombre_familia);

                familiaid = familiaBD is not null ? familiaBD.familiaid : 0;

            }

            if (familiaid == 0)
                familiaid = (await Post(nombre_familia)).Result<long>();

            if (familiaid == 0)
                return BadRequest();
            
            return Ok();
            
        }


        public async Task<ActionResult> Post(string familia)
        {
            FamiliaDTO familiaDTO = new FamiliaDTO() { nombre_familia = familia };

            await _context.Familia.AddAsync(familiaDTO);
            await _context.SaveChangesAsync();

            return Ok(familiaDTO.familiaid);
        }
    }
}
