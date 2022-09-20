using EFCustomerLibrary.EFRepositories;
using EFCustomerLibrary.Enums;
using EFCustomerLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFTests.Integration_tests
{
    public class EFCustomerRepositoryTests
    {
        [Fact]
        public void ShouldBeAbleToCreateRepository()
        {
            var repository = new EFCustomerRepository();

            Assert.NotNull(repository);
        }

        [Fact]
        public void ShouldBeAbleToCreateCustomer()
        {
            EFCustomerFixture.CreateMockCustomer();

        }

        [Fact]
        public void ShouldBeAbleToReadCustomer()
        {
            EFCustomerFixture.CreateMockCustomer();
            var createdCustomer = EFCustomerFixture.CreateCustomerRepository().Get(1);

        }

        [Fact]
        public void ShouldBeAbleToUpdateCustomer()
        {
            var customer = EFCustomerFixture.CreateMockCustomer();
            var repository = EFCustomerFixture.CreateCustomerRepository();
            customer.LastName = "updated2";
            repository.Update(customer);
            var result = repository.Get(1).LastName;
            Assert.Equal(result, "updated2");

        }

        [Fact]
        public void ShouldBeAbleToDeleteCustomer()
        {
            var customer = EFCustomerFixture.CreateMockCustomer();
            var repository = EFCustomerFixture.CreateCustomerRepository();
            repository.Delete(customer.Id);
            var deletedCustomer = repository.Get(1);
            Assert.Null(deletedCustomer);
        }


        public class EFCustomerFixture
        {
            public static Customer CreateMockCustomer()
            {
                List<Address> adressList = new List<Address>();
                Address addItem = new Address
                {
                    FirstLine = "Road Street",
                    SecondLine = "Maint Avenue",
                    Type = AddressType.Billing,
                    City = "Toronto",
                    PostalCode = "346330",
                    State = "Alberta",
                    Country = AvailableCountries.Canada,
                    CustomerId = 1
                };
                adressList.Add(addItem);
                List<string> notesList = new List<string>();
                notesList.Add("note1");
                var repository = new EFCustomerRepository();
                Customer customer = new Customer
                {
                    FirstName = "John",
                    LastName = "Second",
                    Addresses = adressList,
                    Notes = notesList,
                    Email = "ashfjfnh@gmail.com",
                    PhoneNumber = "+16175551212",
                    TotalPurchasesAmount = 4
                };
                repository.Create(customer);
                return customer;
            }

            public static EFCustomerRepository CreateCustomerRepository() => new EFCustomerRepository();
        }

    }
}

