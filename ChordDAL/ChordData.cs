using System.Collections.Generic;
using System.Linq;
using ChordCommon;

namespace ChordDAL
{
    public class ChordData
    {

        public List<Chord> chords = new List<Chord>();

        public static IChordDataService Create()
        {
            //return new InMemoryChordData();
            //return new TextFileChordData();
            //return new JsonChordData();
            return new DBChordDataService();
        }

        public void AddChord(Chord chord)
        {
            chords.Add(chord);
        }

        public List<Chord> GetAllChords()
        {
            return chords;
        }

        public List<Chord> GetChords()
        {
            return chords;
        }

        public Chord SearchChord(string name, string type)
        {
            foreach (Chord chord in chords)
            {
                if (chord.Name.ToUpper() == name.ToUpper() &&
                    chord.Type.ToUpper() == type.ToUpper())
                {
                    return chord;
                }
            }
            return null;

        }

        public bool RemoveChord(string name, string type)
        {
            var chord = SearchChord(name, type);
            if (chord != null)
            {
                chords.Remove(chord);
                return true;
            }
            return false;
        }
    }
}
