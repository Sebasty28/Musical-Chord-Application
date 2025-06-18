using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using ChordCommon;

namespace ChordDAL
{
    public class JsonChordData : IChordDataService
    {
        private static List<Chord> chords = new List<Chord>();
        private static string filePath = "chords.json";

        public JsonChordData()
        {
            ReadFromFile();
        }

        private void ReadFromFile()
        {
            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                chords = JsonSerializer.Deserialize<List<Chord>>(json, new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                }) ?? new List<Chord>();
            }
        }

        private void WriteToFile()
        {
            string json = JsonSerializer.Serialize(chords, new JsonSerializerOptions
            {
                WriteIndented = true
            });
            File.WriteAllText(filePath, json);
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

        public void Edit(Chord chord)
        {
            for (int i = 0; i < chords.Count; i++)
            {
                if (chords[i].Name.ToUpper() == chord.Name.ToUpper() &&
                    chords[i].Type.ToUpper() == chord.Type.ToUpper())
                {
                    chords[i] = chord;
                    WriteToFile();
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
                    chords.RemoveAt(i);
                    WriteToFile();
                    return true;
                }
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
