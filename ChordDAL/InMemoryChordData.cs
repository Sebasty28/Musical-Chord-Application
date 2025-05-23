using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChordCommon;

namespace ChordDAL
{
    public class InMemoryChordData : IChordDataService
    {
        private List<Chord> chords = new List<Chord>();

        public List<Chord> GetAll() 
        {
            return chords;
        }

        public void Add(Chord chord)
        {
            chords.Add(chord);
        }
        public void Save(List<Chord> chords)
        {
            this.chords = chords;
        }
    }
}
