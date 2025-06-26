using System.Collections.Generic;
using System.Linq;
using ChordCommon;

namespace ChordDAL
{
    public class ChordData
    {
        IChordDataService chordDataService;

        public ChordData()
        {
            //chordDataService = new InMemoryChordData();
            //chordDataService = new TextFileChordData();
            //chordDataService = new JsonChordData();
            chordDataService = new DBChordDataService();
        }

        public List<Chord> GetAllChords()
        {
            return chordDataService.GetAll();
        }

        public void AddChord(Chord chord)
        {
            chordDataService.Add(chord);
        }

        public void EditChord(Chord oldChord, Chord updatedChord)
        {
            chordDataService.Edit(oldChord, updatedChord);
        }

        public bool RemoveChord(Chord chord)
        {
           return chordDataService.Delete(chord);
        }

        public void SaveChords(List<Chord> chords)
        {
            chordDataService.Save(chords);
        }

    }
}
