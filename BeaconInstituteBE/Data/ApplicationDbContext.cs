using BeaconInstituteBE.Models;
using Microsoft.EntityFrameworkCore;

namespace BeaconInstituteBE.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<SalahTimes> salahTimes { get; set; }
    }
}
