using EFCustomerLibrary.EFRepositories;
using EFCustomerLibrary.EFRepositories.Repositories;
using EFCustomerLibrary.Intefaces;
using EFCustomerLibrary.Models;

namespace EFTests
{
    public class EFRepositoryTest
    {
        [Fact]
        public void ShouldCreateEFCustomerRepository()
        {
            var efRepository = new EFCustomerRepository();
            Assert.NotNull(efRepository);
            Assert.IsAssignableFrom<IRepository<Customer>>(efRepository);

        }

        [Fact]
        public void ShouldCreateEFAddressRepository()
        {
            var efRepository = new EFAddressRepository();
            Assert.NotNull(efRepository);
            Assert.IsAssignableFrom <IRepository<Address>>(efRepository);
        }
        [Fact]
        public void ShouldCreateEFNoteRepository()
        {
            var efRepository = new EFNoteRepository();
            Assert.NotNull(efRepository);
            Assert.IsAssignableFrom<IRepository<Note>>(efRepository);

        }
    }
}