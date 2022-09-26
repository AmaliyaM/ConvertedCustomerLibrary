using EFCustomerLibrary.EFRepositories.Repositories;
using EFCustomerLibrary.Intefaces;
using EFCustomerLibrary.Models;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Xml.Linq;

namespace EFCustomerLibrary.Controllers
{
    [Route("api/[controller]")]
    public class AddressController : Controller
    {
        IRepository<Address> addressRepository;


        public AddressController()
        {
            addressRepository = new EFAddressRepository();
        }

        [HttpGet(Name = "GetAllItems")]
        public IEnumerable<Address> Get()
        {
            return addressRepository.Get();
        }

        [HttpGet("{id}", Name = "GetAddress")]
        public IActionResult Get(int Id)
        {
            Address address = addressRepository.Get(Id);

            if (address == null)
            {
                return NotFound();
            }

            return new ObjectResult(address);
        }

        [HttpPost]
        public IActionResult Create([FromBody] Address address)
        {
            if (address == null)
            {
                return BadRequest();
            }
            addressRepository.Create(address);
            return CreatedAtRoute("GetTodoItem", new { id = address.Id }, address);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int Id, [FromBody] Address updatedAddress)
        {
            if (updatedAddress == null || updatedAddress.Id != Id)
            {
                return BadRequest();
            }

            var address = addressRepository.Get(Id);
            if (address == null)
            {
                return NotFound();
            }

            addressRepository.Update(updatedAddress);
            return RedirectToRoute("GetAllItems");
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int Id)
        {
            var deletedItem = addressRepository.Delete(Id);

            if (deletedItem == null)
            {
                return BadRequest();
            }

            return new ObjectResult(deletedItem);
        }
    }
}