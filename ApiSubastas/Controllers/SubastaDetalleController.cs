using ApiSubastasEntity.Modelos;
using ApiSubastasEntity.Utilidades;
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


        public async Task<ActionResult<SubastaDetalleDTO>> GetMediaSubataGeneroDia(long subastaid, long generoid, int dias)
        {

            var fechaLimite = DateTime.Now.AddDays(-dias);

            var datos = await _context.SubastaDetalle
            .Where(s => s.fecha >= fechaLimite && s.generoid == generoid && s.subastaid == subastaid)
            .Join(_context.Genero,
                  sd => sd.generoid,
                  g => g.generoid,
                  (sd, g) => new { sd, g })
            .ToListAsync(); // Trae todo a memoria

            var resultado = datos.GroupBy(x => new { x.sd.subastaid, x.g })
            .Select(grupo => new
            {
                genero = grupo.Key.g,
                grupo.Key.subastaid,
                corte1 = grupo.Where(x => x.sd.corte1 != 0).Average(x => (double?)x.sd.corte1) ?? 0,
                corte2 = grupo.Where(x => x.sd.corte2 != 0).Average(x => (double?)x.sd.corte2) ?? 0,
                corte3 = grupo.Where(x => x.sd.corte2 != 0).Average(x => (double?)x.sd.corte3) ?? 0,
                corte4 = grupo.Where(x => x.sd.corte2 != 0).Average(x => (double?)x.sd.corte4) ?? 0,
                corte5 = grupo.Where(x => x.sd.corte2 != 0).Average(x => (double?)x.sd.corte5) ?? 0,
                corte6 = grupo.Where(x => x.sd.corte2 != 0).Average(x => (double?)x.sd.corte6) ?? 0,
                corte7 = grupo.Where(x => x.sd.corte2 != 0).Average(x => (double?)x.sd.corte7) ?? 0,
                corte8 = grupo.Where(x => x.sd.corte2 != 0).Average(x => (double?)x.sd.corte8) ?? 0,
                corte9 = grupo.Where(x => x.sd.corte2 != 0).Average(x => (double?)x.sd.corte9) ?? 0,
                corte10 = grupo.Where(x => x.sd.corte2 != 0).Average(x => (double?)x.sd.corte10) ?? 0,
                corte11 = grupo.Where(x => x.sd.corte2 != 0).Average(x => (double?)x.sd.corte11) ?? 0,
                corte12 = grupo.Where(x => x.sd.corte2 != 0).Average(x => (double?)x.sd.corte12) ?? 0,
                corte13 = grupo.Where(x => x.sd.corte2 != 0).Average(x => (double?)x.sd.corte13) ?? 0,
                corte14 = grupo.Where(x => x.sd.corte2 != 0).Average(x => (double?)x.sd.corte14) ?? 0,
                corte15 = grupo.Where(x => x.sd.corte2 != 0).Average(x => (double?)x.sd.corte15) ?? 0,
            }).ToList();

            return Ok(resultado);
        }

    }
}
