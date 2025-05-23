using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using ChordCommon;

namespace ChordDAL
{
    public class JsonChordData : IChordDataService
    {
        private string filePath = "chords.json";

        public List<Chord> GetAll()
        {
            if (!File.Exists(filePath)) return new List<Chord>();
            var json = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<List<Chord>>(json);
        }

        public void Add(Chord chord)
        {
            var chords = GetAll();
            chords.Add(chord);
            Save(chords);
        }

        public void Save(List<Chord> chords)
        {
            var json = JsonSerializer.Serialize(chords, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath, json);
        }
    }
}