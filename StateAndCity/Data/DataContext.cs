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

        
    }
}
