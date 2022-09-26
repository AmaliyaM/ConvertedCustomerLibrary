using EFCustomerLibrary.EFRepositories;
using EFCustomerLibrary.EFRepositories.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFTests
{
    public class CustomerLibraryDBContextTests
    {
        [Fact]

        void ShouldBeCreateCustomerLibraryDBContext()
        {
            var context = new CustomerLibraryDBContext();
            Assert.NotNull(context);

            Assert.NotNull(context.Customer);
            Assert.NotNull(context.Addresses);
            Assert.NotNull(context.Notes);

        }
    }
}
