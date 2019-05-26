using Microsoft.EntityFrameworkCore;

namespace WebApp5.Models.DbContext
{
    public class AppContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public AppContext(DbContextOptions<AppContext> options)
            : base(options)
        { }

        public DbSet<Person> Persons { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region PersonSeed
            modelBuilder.Entity<Person>().HasData(
                new Person { Id = 1, Name = "Nikola" },
                new Person { Id = 2, Name = "Vanja" },
                new Person { Id = 3, Name = "Jovan" },
                new Person { Id = 4, Name = "Dimitrije" },
                new Person { Id = 5, Name = "Milica" }
                );
            #endregion
        }
    }
}
