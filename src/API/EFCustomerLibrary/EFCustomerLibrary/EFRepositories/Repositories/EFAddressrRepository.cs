using EFCustomerLibrary.Intefaces;
using EFCustomerLibrary.Models;

namespace EFCustomerLibrary.EFRepositories.Repositories
{
    public class EFAddressRepository : IRepository<Address>
    {
        private readonly CustomerLibraryDBContext _context;
        public EFAddressRepository()
        {
            _context = new CustomerLibraryDBContext();
        }

        public IEnumerable<Address> Get()
        {
            return _context.Addresses;
        }
        public void Create(Address address)
        {
            _context
                .Addresses
                .Add(address);

            _context.SaveChanges();

        }

        public Address Delete(int id)
        {
            var address = Get(id);

            _context
                .Addresses
                .Remove(address);

            _context.SaveChanges();

            return address;
        }

        public void DeleteAll()
        {
            _context
                .Addresses
                .RemoveRange(_context.Addresses);
            _context.SaveChanges();
        }

        public Address Get(int id)
        {
            return _context.Addresses.Find(id);
        }

        public void Update(Address address)
        {
            var exist = Get(address.Id);
            _context
                .Entry(exist)
                .CurrentValues.SetValues(address);

            _context.SaveChanges();

        }
    }
}