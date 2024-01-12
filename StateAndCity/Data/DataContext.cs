using Microsoft.EntityFrameworkCore;
using StateAndCity.Models;

namespace StateAndCity.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {
        }
        public DbSet<StateModel> States { get; set; }
        public DbSet<CityModel> Cities { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<CityModel>()
                .HasKey(c => c.CityId);

            // Define primary key for CityModel
        modelBuilder.Entity<CityModel>()
            .HasKey(c => c.CityId);

        // Define foreign key relationship between CityModel and StateModel
        modelBuilder.Entity<CityModel>()
            .HasOne(c => c.State)
            .WithMany(s => s.Cities)
            .HasForeignKey(c => c.StateId)
            .OnDelete(DeleteBehavior.Cascade); // Choose appropriate delete behavior

        // Define primary key for StateModel
        modelBuilder.Entity<StateModel>()
            .HasKey(s => s.StateId);

        

        // Example: Adding unique constraint on StateName in StateModel
        modelBuilder.Entity<StateModel>()
            .HasIndex(s => s.StateName)
            .IsUnique();
        }

    }
}
