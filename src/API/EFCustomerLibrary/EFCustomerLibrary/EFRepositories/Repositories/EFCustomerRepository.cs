using EFCustomerLibrary.Intefaces;
using EFCustomerLibrary.Models;

namespace EFCustomerLibrary.EFRepositories.Repositories
{
    public class EFCustomerRepository : IRepository<Customer>
    {
        private readonly CustomerLibraryDBContext _context;
        public EFCustomerRepository()
        {
            _context = new CustomerLibraryDBContext();
        }

        public IEnumerable<Customer> Get()
        {
            return _context.Customer;
        }
        public void Create(Customer customer)
        {
            _context
                .Customer
                .Add(customer);

            _context.SaveChanges();

        }

        public Customer Delete(int id)
        {
            var customer = Get(id);

            _context
                .Customer
                .Remove(customer);

            _context.SaveChanges();

            return customer;
        }

        public void DeleteAll()
        {
            _context
                .Customer
                .RemoveRange(_context.Customer);
            _context.SaveChanges();
        }

        public Customer Get(int id)
        {
            return _context.Customer.Find(id);
        }

        public void Update(Customer customer)
        {
            var exist = Get(customer.Id);
            _context
                .Entry(exist)
                .CurrentValues.SetValues(customer);

            _context.SaveChanges();

        }
    }
}
