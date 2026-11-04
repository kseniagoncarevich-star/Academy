using Microsoft.EntityFrameworkCore;

public class AcademyCWContext(DbContextOptions<AcademyCWContext> options) : DbContext(options)
{
    public DbSet<AcademyCW.Models.Direction> Directions { get; set; } = default!;
    public DbSet<AcademyCW.Models.Group> Groups { get; set; } = default!;
    public DbSet<AcademyCW.Models.Student> Students { get; set; } = default!;
    public DbSet<AcademyCW.Models.Discipline> Disciplines { get; set; } = default!;
    public DbSet<AcademyCW.Models.Teacher> Teachers { get; set; } = default!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AcademyCW.Models.Teacher>()
            .HasMany(t => t.Disciplines)
            .WithMany(d => d.Teachers)
            .UsingEntity("TeachersDisciplinesRelation",
                l => l.HasOne(typeof(AcademyCW.Models.Discipline)).WithMany().HasForeignKey("discipline"),
                r => r.HasOne(typeof(AcademyCW.Models.Teacher)).WithMany().HasForeignKey("teacher"),
                j => j.HasKey("teacher", "discipline"));
    }

}
