using System;
using System.Collections.Generic;
using System.Linq;

namespace NotesAPI.Models
{
    public class NoteRepository : INoteRepository
    {
        private readonly NoteContext _context;

        public NoteRepository(NoteContext context)
        {
            _context = context;
        }

        public IEnumerable<Note> GetAllNotes(string query)
        {
            if (!String.IsNullOrEmpty(query))
            {
                //return any matching notes, case-insensitive
                return _context.Notes
                    .Where(n => n.body.ToLower().Contains(query.ToLower()))
                    .ToList();
            }

            return _context.Notes.ToList();

        }

        public void AddNote(Note note)
        {
            _context.Notes.Add(note);
            _context.SaveChanges();
        }

        public Note GetNoteById(int id)
        {
            return _context.Notes.FirstOrDefault(t => t.id == id);
        }
    }
}
