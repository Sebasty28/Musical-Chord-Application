using System;
using System.Collections.Generic;
using ChordCommon;

namespace ChordDAL
{
    public class InMemoryChordData : IChordDataService
    {
        private List<Chord> chords = new List<Chord>();

        public List<Chord> GetAll()
        {
            return new List<Chord>(chords);
        }

        public void Add(Chord chord)
        {
            chords.Add(chord);
        }

        public void Edit(Chord oldChord, Chord updatedChord)
        {
            for (int i = 0; i < chords.Count; i++)
            {
                if (chords[i].Name.ToUpper() == oldChord.Name.ToUpper() &&
                    chords[i].Type.ToUpper() == oldChord.Type.ToUpper() &&
                    chords[i].Notes.ToUpper() == oldChord.Notes.ToUpper())
                {
                    chords[i].Name = updatedChord.Name;
                    chords[i].Type = updatedChord.Type;
                    chords[i].Notes = updatedChord.Notes;
                    break;
                }
            }
        }

        public bool Delete(Chord chord)
        {
            for (int i = 0; i < chords.Count; i++)
            {
                if (chords[i].Name.ToUpper() == chord.Name.ToUpper() &&
                    chords[i].Type.ToUpper() == chord.Type.ToUpper())
                {
                    List<Chord> another = new List<Chord>();
                    for (int j = 0; j < chords.Count; j++)
                    {
                        if (j != i)
                        {
                            another.Add(chords[j]);
                        }
                    }
                    chords = another;
                    return true;
                }
            }
            return false;
        }

        public void Save(List<Chord> chords)
        {
            this.chords = new List<Chord>();
            for (int i = 0; i < chords.Count; i++)
            {
                this.chords.Add(chords[i]);
            }
        }
    }
}
