using Microsoft.EntityFrameworkCore;

public class AcademyCWContext(DbContextOptions<AcademyCWContext> options) : DbContext(options)
{
    public DbSet<AcademyCW.Models.Direction> Directions { get; set; } = default!;
}
