using ChordBLL;
using ChordCommon;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace MusicalChordAppAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MusicalChordAppController : ControllerBase
    {

        private readonly ChordManager _chordManager;

        public MusicalChordAppController(ChordManager atmService)
        {
            _chordManager = atmService;
        }

        [HttpGet("View")]
        public List<Chord> GetAllChords()
        {
            return _chordManager.GetAllChords();
        }

        [HttpPost("Add")]
        public bool AddChord(Chord chord)
        {
            string notes = _chordManager.GenerateChordNotes(chord.Name, chord.Type);

            if (notes == "Unknown chord" || notes == "Unknown chord type")
                return false;

            return _chordManager.AddChord(chord.Name, chord.Type, notes);
        }

        [HttpPatch("Edit")]
        public bool EditChord(string oldName, string oldType, string newName, string newType)
        {
            string updatedNotes;
            return _chordManager.EditChord(oldName, oldType, newName, newType, out updatedNotes);
        }

        [HttpDelete("Delete")]
        public bool DeleteChord(string name, string type)
        {
            return _chordManager.DeleteChord(name, type);
        }

        [HttpGet("Search")]
        public Chord SearchChord(string name, string type)
        {
            return _chordManager.SearchChord(name, type);
        }

        [HttpGet("Progression")]
        public IActionResult GetChordProgression()
        {
            var progression = _chordManager.GenerateProgression();

            if (progression == null || progression.Count == 0)
                return NotFound("Not enough chords to generate a progression.");

            if (!_chordManager.SendChordProgression(progression))
                return StatusCode(500, "Error sending chord progression email.");

            return Ok(new
            {
                message = "Chord progression email sent successfully.",
                progression
            });
        }

    }
}
