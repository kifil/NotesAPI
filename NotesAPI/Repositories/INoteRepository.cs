using System.Collections.Generic;

namespace NotesAPI.Models
{
    public interface INoteRepository
    {
        void AddNote(Note note);
        IEnumerable<Note> GetAllNotes(string query);
        Note GetNoteById(int id);
    }
}
