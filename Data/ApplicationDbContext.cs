using JobFinder.Models;
using Microsoft.EntityFrameworkCore;

namespace JobFinder.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Job> Jobs { get; set; } = null!;
        public DbSet<Company> Companies { get; set; } = null!;
        public DbSet<Technology> Technologies { get; set; } = null!;
        public DbSet<User> Users { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<JobTechnology>(entity =>
            {
                entity.HasKey(jt => new {jt.JobId, jt.TechnologyId});

                entity.HasOne(jt => jt.Job)
                .WithMany(j => j.JobTechnologies)
                .HasForeignKey(jt => jt.JobId);
            });

            modelBuilder.Entity<Job>()
                .Property(j => j.JobType)
                .HasConversion<string>();

        }



    }
}
