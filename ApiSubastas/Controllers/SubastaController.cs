using ApiSubastasEntity.Modelos;
using APISubastasEntity.Controllers.Base;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ApiSubastasEntity.Controllers
{
    public class SubastaController : BaseControlador
    {
        public SubastaController()
        { }

        public async Task<ActionResult<List<SubastaDTO>>> Get()
        {
            return Ok(await _context.Subasta.ToListAsync());
        }




    }
}
