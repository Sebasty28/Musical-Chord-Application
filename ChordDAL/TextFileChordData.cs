using System;
using System.Collections.Generic;
using System.IO;
using ChordCommon;

namespace ChordDAL
{
    public class TextFileChordData : IChordDataService
    {
        private string filePath = "chords.txt";
        private List<Chord> chords = new List<Chord>();

        public TextFileChordData()
        {
            ReadFromFile();
        }

        private void ReadFromFile()
        {
            chords.Clear();

            if (!File.Exists(filePath))
                return;

            string[] lines = File.ReadAllLines(filePath);

            for (int i = 0; i < lines.Length; i++)
            {
                string line = lines[i];
                string[] parts = line.Split('|');

                if (parts.Length >= 2)
                {
                    string name = parts[0];
                    string type = parts[1];
                    string notes = parts.Length >= 3 ? parts[2] : "";

                    Chord chord = new Chord(name, type, notes);
                    chords.Add(chord);
                }
            }
        }

        private void WriteToFile()
        {
            string[] lines = new string[chords.Count];

            for (int i = 0; i < chords.Count; i++)
            {
                string name = chords[i].Name;
                string type = chords[i].Type;
                string notes = chords[i].Notes;

                lines[i] = string.Concat(name, "|", type, "|", notes);
            }

            File.WriteAllLines(filePath, lines);
        }

        private int FindChordIndex(Chord chord)
        {
            for (int i = 0; i < chords.Count; i++)
            {
                string name1 = chords[i].Name.ToUpper();
                string type1 = chords[i].Type.ToUpper();
                string name2 = chord.Name.ToUpper();
                string type2 = chord.Type.ToUpper();

                if (name1 == name2 && type1 == type2)
                {
                    return i;
                }
            }

            return -1;
        }

        public List<Chord> GetAll()
        {
            return chords;
        }

        public void Add(Chord chord)
        {
            chords.Add(chord);
            WriteToFile();
        }

        public void Edit(Chord oldChord, Chord updatedChord)
        {
            int index = FindChordIndex(oldChord);
            if (index != -1)
            {
                chords[index] = updatedChord;
                WriteToFile();
            }
        }

        public bool Delete(Chord chord)
        {
            int index = FindChordIndex(chord);
            if (index != -1)
            {
                chords.RemoveAt(index);
                WriteToFile();
                return true;
            }
            return false;
        }

        public void Save(List<Chord> updatedChords)
        {
            chords = updatedChords;
            WriteToFile();
        }
    }
}
