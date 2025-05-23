using System.Collections.Generic;
using System.IO;
using ChordCommon;

namespace ChordDAL
{
    public class TextFileChordData : IChordDataService
    {
        private string filePath = "chords.txt";

        public List<Chord> GetAll()
        {
            var chords = new List<Chord>();
            if (File.Exists(filePath))
            {
                foreach (var line in File.ReadAllLines(filePath))
                {
                    var parts = line.Split('|');
                    chords.Add(new Chord(parts[0], parts[1]));
                }
            }
            return chords;
        }

        public void Add(Chord chord)
        {
            var line = $"{chord.Name}|{chord.Type}";
            File.AppendAllLines(filePath, new[] { line });
        }

        public void Save(List<Chord> chords)
        {
            var lines = new List<string>();
            foreach (var chord in chords)
            {
                lines.Add($"{chord.Name}|{chord.Type}");
            }
            File.WriteAllLines(filePath, lines);
        }
    }
}