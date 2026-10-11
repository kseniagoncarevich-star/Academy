using Microsoft.EntityFrameworkCore;
using Academy.Models;

namespace Academy.wwwroot
{
    public class AcademyDbContext : DbContext
    {
        public AcademyDbContext(DbContextOptions<AcademyDbContext> options) : base(options) { }

        public DbSet<Direction> Directions { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
    }
}