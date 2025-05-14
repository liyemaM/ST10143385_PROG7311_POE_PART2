using PROGPOE1.Models.DBEntities;
using Microsoft.EntityFrameworkCore;
using PROGPOE1.Models;


namespace PROGPOE1.DAL
{
    public class EmployeeDbContext : DbContext
    {
        public EmployeeDbContext(DbContextOptions<EmployeeDbContext> options) : base(options) { }

        public DbSet<AppUser> Users { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Farmer> Farmers { get; set; }
    }

}
