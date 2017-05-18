using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NotesAPI.Models
{
    public interface INoteRepository
    {
        void AddNote(Note note);
        IEnumerable<Note> GetAllNotes(string query);
        Note GetNoteById(int id);
    }
}
