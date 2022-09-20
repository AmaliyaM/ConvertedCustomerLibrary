using EFCustomerLibrary.EFRepositories;
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

            Assert.NotNull(context.Customers);
            Assert.NotNull(context.Addresses);
            Assert.NotNull(context.Notes);

        }
    }
}
