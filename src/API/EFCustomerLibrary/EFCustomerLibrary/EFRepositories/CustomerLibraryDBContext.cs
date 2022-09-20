using EFCustomerLibrary.Models;
using Microsoft.EntityFrameworkCore;

namespace EFCustomerLibrary.EFRepositories
{
    public class CustomerLibraryDBContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }

        public DbSet<Address> Addresses { get; set; }
        public DbSet<Note> Notes { get; set; }


    }
}
