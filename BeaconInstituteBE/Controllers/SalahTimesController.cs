using BeaconInstituteBE.Data;
using BeaconInstituteBE.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace BeaconInstituteBE.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SalahTimesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public SalahTimesController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet("{date}")]
        public async Task<ActionResult<SalahTimes>> GetSalahTimes(string date)
        {
            if (!DateOnly.TryParse(date, out DateOnly parsedDate))
            {
                return BadRequest("Invalid date format. Please use YYYY-MM-DD.");
            }

            var salahTimes = await _context.salah_times.SingleOrDefaultAsync(pt => pt.d_date == parsedDate);
            if (salahTimes == null)
            {
                return NotFound();
            }

            return salahTimes;
        }
    }
}
