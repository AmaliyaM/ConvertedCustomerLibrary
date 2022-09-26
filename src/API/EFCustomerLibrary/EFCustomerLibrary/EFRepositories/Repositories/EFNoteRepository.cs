using EFCustomerLibrary.Intefaces;
using EFCustomerLibrary.Models;

namespace EFCustomerLibrary.EFRepositories.Repositories
{
    public class EFNoteRepository : IRepository<Note>
    {
        private readonly CustomerLibraryDBContext _context;
        public EFNoteRepository()
        {
            _context = new CustomerLibraryDBContext();
        }

        public IEnumerable<Note> Get()
        {
            return _context.Notes;
        }
        public void Create(Note note)
        {
            _context
                .Notes
                .Add(note);

            _context.SaveChanges();

        }

        public Note Delete(int id)
        {
            var note = Get(id);

            _context
                .Notes
                .Remove(note);

            _context.SaveChanges();

            return note;
        }

        public void DeleteAll()
        {
            _context
                .Notes
                .RemoveRange(_context.Notes);
            _context.SaveChanges();
        }

        public Note Get(int id)
        {
            return _context.Notes.Find(id);
        }

        public void Update(Note note)
        {
            var exist = Get(note.Id);
            _context
                .Entry(exist)
                .CurrentValues.SetValues(note);

            _context.SaveChanges();

        }
    }
}
