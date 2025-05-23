using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChordCommon;

namespace ChordDAL
{
    public interface IChordDataService
    {
        public List<Chord> GetAll();
        public void Add(Chord chord);
        public void Save(List<Chord> chords);
    }
}
