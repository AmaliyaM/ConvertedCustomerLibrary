using EFCustomerLibrary.Models;
using Microsoft.EntityFrameworkCore;

namespace EFCustomerLibrary.EFRepositories.Repositories
{
    public class CustomerLibraryDBContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
          {
            optionsBuilder.UseSqlServer("server=.;database=CustomerLib_Melenteva;trusted_connection=true;");
          }

        public DbSet<Customer> Customer { get; set; }

        public DbSet<Address> Addresses { get; set; }
        public DbSet<Note> Notes { get; set; }


    }
}
