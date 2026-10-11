using Microsoft.EntityFrameworkCore;

public class AcademyCWContext(DbContextOptions<AcademyCWContext> options) : DbContext(options)
{
    public DbSet<AcademyCW.Models.Direction> Direction { get; set; } = default!;
}
