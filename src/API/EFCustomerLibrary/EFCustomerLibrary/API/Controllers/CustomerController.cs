using EFCustomerLibrary.EFRepositories.Repositories;
using EFCustomerLibrary.Intefaces;
using EFCustomerLibrary.Models;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

namespace EFCustomerLibrary.Controllers
{
    [Route("api/[controller]")]
    public class CustomerController : Controller
    {
        IRepository<Customer> customerRepository;


        public CustomerController()
            {
                customerRepository = new EFCustomerRepository();

            }

            [HttpGet(Name = "GetAllItems")]
            public IEnumerable<Customer> Get()
            {
                return customerRepository.Get();
            }

            [HttpGet("{id}", Name = "GetCustomer")]
            public IActionResult Get(int Id)
            {
                Customer customer = customerRepository.Get(Id);

                if (customer == null)
                {
                    return NotFound();
                }

                return new ObjectResult(customer);
            }

            [HttpPost]
            public IActionResult Create([FromBody] Customer customer)
            {
                if (customer == null)
                {
                    return BadRequest();
                }
            customerRepository.Create(customer);
                return CreatedAtRoute("GetTodoItem", new { id = customer.Id }, customer);
            }

            [HttpPut("{id}")]
            public IActionResult Update(int Id, [FromBody] Customer updatedCustomer)
            {
                if (updatedCustomer == null || updatedCustomer.Id != Id)
                {
                    return BadRequest();
                }

                var customer = customerRepository.Get(Id);
                if (customer == null)
                {
                    return NotFound();
                }

            customerRepository.Update(updatedCustomer);
                return RedirectToRoute("GetAllItems");
            }

            [HttpDelete("{id}")]
            public IActionResult Delete(int Id)
            {
                var deletedItem = customerRepository.Delete(Id);

                if (deletedItem == null)
                {
                    return BadRequest();
                }

                return new ObjectResult(deletedItem);
            }
        }
    }
