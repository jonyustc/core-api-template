using CoreApi.Persistence.Models;
using Microsoft.EntityFrameworkCore;

namespace CoreApi.Persistence
{
    public class DataContext : DbContext
    {

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Employee>().HasKey(x => x.Id);
        }
    }
}
