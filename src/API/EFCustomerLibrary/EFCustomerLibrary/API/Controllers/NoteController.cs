using EFCustomerLibrary.EFRepositories.Repositories;
using EFCustomerLibrary.Intefaces;
using EFCustomerLibrary.Models;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

namespace EFCustomerLibrary.Controllers
{
    [Route("api/[controller]")]
    public class NoteController : Controller
    {
        IRepository<Note> noteRepository;


        public NoteController()
        {
            noteRepository = new EFNoteRepository();
        }

        [HttpGet(Name = "GetAllItems")]
        public IEnumerable<Note> Get()
        {
            return noteRepository.Get();
        }

        [HttpGet("{id}", Name = "GetNote")]
        public IActionResult Get(int Id)
        {
            Note note = noteRepository.Get(Id);

            if (note == null)
            {
                return NotFound();
            }

            return new ObjectResult(note);
        }

        [HttpPost]
        public IActionResult Create([FromBody] Note note)
        {
            if (note == null)
            {
                return BadRequest();
            }
            noteRepository.Create(note);
            return CreatedAtRoute("GetTodoItem", new { id = note.Id }, note);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int Id, [FromBody] Note updatedNote)
        {
            if (updatedNote == null || updatedNote.Id != Id)
            {
                return BadRequest();
            }

            var note = noteRepository.Get(Id);
            if (note == null)
            {
                return NotFound();
            }

            noteRepository.Update(updatedNote);
            return RedirectToRoute("GetAllItems");
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int Id)
        {
            var deletedItem = noteRepository.Delete(Id);

            if (deletedItem == null)
            {
                return BadRequest();
            }

            return new ObjectResult(deletedItem);
        }
    }
}