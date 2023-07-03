using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TiketApi.Context;
using TiketApi.DataModels;
using TiketApi.Models;

namespace TiketApi.Controllers
{
    [Route("TiketApi/[controller]")]
    [ApiController]
    public class TiketsController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;

        public TiketsController(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpPost]
        [Route("buat")]

        public async Task<IActionResult> BuatTiket(BuatTiket buatTiket)
        {
            var newTiket = new TiketModel();
            _mapper.Map(buatTiket, newTiket);
            await _context.AddAsync(newTiket);
            await _context.SaveChangesAsync();
            return Ok(newTiket);

        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AllDataTiket>>> GetAll(string? cari)
        {
            //iquery di pakai jika ada parameter
            IQueryable<TiketModel> query = _context.Tikets;
            if (cari is not null)
                query = query.Where(t => t.NamaPenumpang.Contains(cari));
            var datas = query.ToListAsync();
            //var datas = await _context.Tikets.ToListAsync();
            var converteddata = _mapper.Map<IEnumerable<AllDataTiket>>(datas);
            //return Ok(datas);
            return Ok(converteddata);
        }
        [HttpGet]
        [Route("{id}")]
        public async Task<ActionResult<IEnumerable<AllDataTiket>>> TiketId([FromRoute] long id)
        {
            //cara 1
            //var datas = await _context.Tikets.Where(a=>a.Id == id).ToListAsync();
            //cara 2
            var datas = await _context.Tikets.FirstOrDefaultAsync(a => a.Id == id);
            if (datas is null)
                return NotFound("tiket tidak ada");
            var converteddata = _mapper.Map<IEnumerable<AllDataTiket>>(datas);
            //return Ok(datas);
            return Ok(converteddata);
        }
        [HttpPut]
        [Route("edit/{id}")]
        public async Task<IActionResult> EditTiket([FromRoute] long id, [FromBody] UpdateTiket updateTiket)
        {
            //cara 1
            //var datas = await _context.Tikets.Where(a=>a.Id == id).ToListAsync();
            //cara 2
            var datas = await _context.Tikets.FirstOrDefaultAsync(a => a.Id == id);
            if (datas is null)
                return NotFound("tiket tidak ada");
            _mapper.Map(updateTiket, datas);
            datas.WaktuUpdate = DateTime.Now;
            await _context.SaveChangesAsync();
            //return Ok(datas);
            return Ok("tiket update");
        }
        [HttpDelete]
        [Route("hapus/{id}")]
        public async Task<IActionResult> HapusTiket([FromRoute] long id)
        {
            var datas = await _context.Tikets.FirstOrDefaultAsync(a => a.Id == id);
            if (datas is null)
                return NotFound("tiket tidak ada");
            _context.Tikets.Remove(datas);
            await _context.SaveChangesAsync();
            return Ok("tiket dihapus");
        }
    }
}
