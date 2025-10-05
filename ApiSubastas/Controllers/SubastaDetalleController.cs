using ApiSubastasEntity.Modelos;
using APISubastasEntity.Controllers.Base;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ApiSubastasEntity.Controllers
{
    public class SubastaDetalleController : BaseControlador
    {


        public SubastaDetalleController()
        {
        }

        #region GET

        public async Task<ActionResult<List<SubastaDetalleDTO>>> GetSubastaFecha(long subastaid, DateTime fecha)
        {
            var lista = await _context.SubastaDetalle
                .Where(u => u.subastaid == subastaid)
                .Where(u => u.fecha == fecha)
                .Include(g => g.Genero)
                .ToListAsync();
            return Ok(lista);
        }


        public async Task<ActionResult<List<SubastaDetalleDTO>>> GetSubastaFechaGenero(long subastaid, DateTime fecha,long generoid)
        {
            var lista = await _context.SubastaDetalle
                .Where(u => u.subastaid == subastaid)
                .Where(u => u.generoid == generoid)
                .Where(u => u.fecha == fecha)
                .Include(g => g.Genero)
                .ToListAsync();
            return Ok(lista);
        }

        public async Task<ActionResult<List<SubastaDetalleDTO>>> GetUltimaSubasta(long subastaid)
        {
            var fechaMaxQuery = _context.SubastaDetalle.Where(u => u.subastaid == subastaid);
            var fechaMax = await fechaMaxQuery.MaxAsync(u => u.fecha);

            var queryfinal = _context.SubastaDetalle.Where(u => u.subastaid == subastaid && u.fecha == fechaMax);
            var resultado = await queryfinal.Include(s => s.Genero).ToListAsync();

            return Ok(resultado);
        }

        public async Task<ActionResult<List<SubastaDetalleDTO>>> GetUltimaSubastaGenero(long subastaid, long generoid)
        {
            var fechaMaxQuery = _context.SubastaDetalle.Where(u => u.subastaid == subastaid);
            var fechaMax = await fechaMaxQuery.MaxAsync(u => u.fecha);

            var queryfinal = _context.SubastaDetalle.Where(u => u.subastaid == subastaid && u.generoid == generoid && u.fecha == fechaMax);
            var resultado = await queryfinal.Include(s => s.Genero).ToListAsync();

            return Ok(resultado);
        }

        #endregion

        public async Task<ActionResult> Post(SubastaDetalleDTO subastaDetalleDTO)
        {
            var resultado = await _context.SubastaDetalle.AddAsync(subastaDetalleDTO);
            await _context.SaveChangesAsync();
            return Ok(resultado);
        }

        public async Task<ActionResult<SubastaDetalleDTO>> GetSubastaDetalle(long subastaid, long generoid, DateTime fecha)
        {
            var subastafamilia = await _context.SubastaDetalle.FirstOrDefaultAsync(u => u.subastaid == subastaid && u.generoid == generoid && u.fecha == fecha);
            return Ok(subastafamilia);
        }


        public async Task<ActionResult> DeleteFecha(DateTime fecha)
        {
            var resultad = await _context.SubastaDetalle.Where(u => u.fecha == fecha).ExecuteDeleteAsync();
            await _context.SaveChangesAsync();
            return Ok(resultad);
        }


        public async Task<ActionResult> DeleteID(long subastadetalleid)
        {
            await _context.SubastaDetalle.Where(u=> u.subastadetalleid == subastadetalleid).ExecuteDeleteAsync();
            await _context.SaveChangesAsync();
            return Ok();
        }

        public async Task<ActionResult> DeleteFechaID(DateTime fecha,long subastaid)
        {

            await _context.SubastaDetalle.Where(u => u.fecha == fecha && u.subastaid == subastaid).ExecuteDeleteAsync();
            await _context.SaveChangesAsync();
            return Ok();
           
        }

    }
}
