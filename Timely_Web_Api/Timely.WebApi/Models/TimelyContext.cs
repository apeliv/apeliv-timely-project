using Microsoft.EntityFrameworkCore;

namespace Timely.WebApi.Models;

public partial class TimelyContext : DbContext
{
    private readonly string connect_string= "Data Source=DESKTOP-DL12C5C;Initial Catalog=timely;Integrated Security=True;Encrypt=False";
    public TimelyContext()
    {
    }

    public TimelyContext(DbContextOptions<TimelyContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Project> Projects { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer(connect_string);

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Project>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("project_pk");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Duration).HasColumnName("duration");
            entity.Property(e => e.EndTime)
                .HasColumnType("datetime")
                .HasColumnName("end_time");
            entity.Property(e => e.ProjectName)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("project_name");
            entity.Property(e => e.StartTime)
                .HasColumnType("datetime")
                .HasColumnName("start_time");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
