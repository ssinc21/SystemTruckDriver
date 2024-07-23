using Microsoft.EntityFrameworkCore;
using SystemTruckDriver.Models;

namespace SystemTruckDriver.Data
{
    public class SystemTruckDbContext : DbContext
    {
        public SystemTruckDbContext(DbContextOptions<SystemTruckDbContext> options) : base(options)
        {

        }

        public DbSet<DriverModel> Drivers { get; set; }
        public DbSet<TruckModel> Trucks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
