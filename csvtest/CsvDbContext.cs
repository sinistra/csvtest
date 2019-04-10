using Microsoft.EntityFrameworkCore;

namespace csvtest
{
    public class CsvDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source=csv.Db");
        }

        public DbSet<Person> Persons { get; set; }

        public DbSet<Address> Addresses { get; set; }

    }
}