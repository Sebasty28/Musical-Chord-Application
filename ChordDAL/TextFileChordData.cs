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

            var lines = File.ReadAllLines(filePath);

            foreach (var line in lines)
            {
                var parts = line.Split('|');
                if (parts.Length >= 2)
                {
                    var name = parts[0];
                    var type = parts[1];
                    var notes = parts.Length >= 3 ? parts[2] : string.Empty;

                    chords.Add(new Chord(name, type, notes));
                }
            }
        }

        private void WriteToFile()
        {
            var lines = new string[chords.Count];
            for (int i = 0; i < chords.Count; i++)
            {
                lines[i] = $"{chords[i].Name}|{chords[i].Type}|{chords[i].Notes}";
            }
            File.WriteAllLines(filePath, lines);
        }

        private int FindChordIndex(Chord chord)
        {
            for (int i = 0; i < chords.Count; i++)
            {
                if (chords[i].Name.Equals(chord.Name, StringComparison.OrdinalIgnoreCase) &&
                    chords[i].Type.Equals(chord.Type, StringComparison.OrdinalIgnoreCase))
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
