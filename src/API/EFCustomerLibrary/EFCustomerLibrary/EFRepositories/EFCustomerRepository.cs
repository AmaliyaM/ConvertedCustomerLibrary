using EFCustomerLibrary.Intefaces;
using EFCustomerLibrary.Models;

namespace EFCustomerLibrary.EFRepositories
{
    public class EFCustomerRepository : IRepository<Customer>
    {
        private readonly CustomerLibraryDBContext _context;
        public EFCustomerRepository()
        {
            _context = new CustomerLibraryDBContext();
        }
        public void Create(Customer customer)
        {
            _context
                .Customers
                .Add(customer);

            _context.SaveChanges();

        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void DeleteAll()
        {
            throw new NotImplementedException();
        }

        public Customer Get(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Customer entity)
        {
            throw new NotImplementedException();
        }
    }
}
