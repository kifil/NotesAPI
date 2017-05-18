using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NotesAPI.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace NotesAPI.Controllers
{
    //[Route("api/[controller]")]
    [Route("api/notes")]
    public class NoteController : Controller
    {
        private readonly INoteRepository _noteRepository;

        public NoteController(INoteRepository noteRepository)
        {
            _noteRepository = noteRepository;
        }

        [HttpGet]
        public IEnumerable<Note> GetAll(string query)
        {
            return _noteRepository.GetAllNotes(query);
        }

        [HttpGet("{id}", Name = "GetNoteById")]
        public IActionResult GetNoteById(int id)
        {
            var item = _noteRepository.GetNoteById(id);
            if (item == null)
            {
                return NotFound();
            }

            //jsonresult?
            return new ObjectResult(item);
        }

        [HttpPost]
        public IActionResult Create([FromBody] Note note)
        {
            if (note == null)
            {
                return BadRequest();
            }

            _noteRepository.AddNote(note);

            return CreatedAtRoute("GetNoteById", new { id = note.id }, note);
        }

    }
}
