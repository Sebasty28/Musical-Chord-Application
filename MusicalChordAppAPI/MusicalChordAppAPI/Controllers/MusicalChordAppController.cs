using Microsoft.AspNetCore.Mvc;
using ChordCommon;
using ChordBLL;

namespace MusicalChordAppAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MusicalChordAppController : ControllerBase
    {
        ChordManager chordManager = new ChordManager();

        [HttpGet("View")]
        public List<Chord> GetAllChords()
        {
            return chordManager.GetAllChords();
        }

        [HttpPost("Add")]
        public bool AddChord(Chord chord)
        {
            string notes = chordManager.GenerateChordNotes(chord.Name, chord.Type);

            if (notes == "Unknown chord" || notes == "Unknown chord type")
                return false;

            return chordManager.AddChord(chord.Name, chord.Type, notes);
        }

        [HttpPatch("Edit")]
        public bool EditChord(string oldName, string oldType, string newName, string newType)
        {
            string updatedNotes;
            return chordManager.EditChord(oldName, oldType, newName, newType, out updatedNotes);
        }

        [HttpDelete("Delete")]
        public bool DeleteChord(string name, string type)
        {
            return chordManager.DeleteChord(name, type);
        }

        [HttpGet("Search")]
        public Chord SearchChord(string name, string type)
        {
            return chordManager.SearchChord(name, type);
        }


    }
}
