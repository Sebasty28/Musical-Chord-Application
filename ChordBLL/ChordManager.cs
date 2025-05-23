using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChordDAL;
using ChordCommon;

namespace ChordBLL
{
    public class ChordManager
    {
        ChordData GetChordData = new ChordData();

        public void AddChord(string name, string type)
        {
            if (GetChordData.SearchChord(name, type) != null)
            {
                Console.WriteLine("Chord already exists!\n");
                return;
            }
            GetChordData.AddChord(new Chord(name, type));
            Console.WriteLine("Chord added successfully!\n");
        }

        public void EditChord(string oldName, string oldType, string newName, string newType)
        {
            var chord = GetChordData.SearchChord(oldName, oldType);
            if (chord == null)
            {
                Console.WriteLine("Chord not found!\n");
                return;
            }

            chord.Name = newName.ToUpper();
            chord.Type = newType.ToUpper();
            Console.WriteLine("Chord updated successfully!\n");
        }

        public void DeleteChord(string name, string type)
        {
            if (GetChordData.RemoveChord(name, type))
                Console.WriteLine("Chord deleted successfully!\n");
            else
                Console.WriteLine("Chord not found!\n");
        }

        public void SearchChord(string name, string type)
        {
            var chord = GetChordData.SearchChord(name, type);
            if (chord != null)
                Console.WriteLine("Chord found: " + chord);
            else
                Console.WriteLine("Chord not found!\n");
        }

        public void ListAllChords()
        {
            var allChords = GetChordData.GetAllChords();
            if (allChords.Count == 0)
            {
                Console.WriteLine("No chords available.\n");
                return;
            }

            Console.WriteLine("All Chords:");
            foreach (var chord in allChords)
            {
                Console.WriteLine(chord);
            }
        }

        public void GenerateProgression()
        {
            var allChords = GetChordData.GetAllChords();
            if (allChords.Count < 4)
            {
                Console.WriteLine("Not enough chords to generate a progression.\n");
                return;
            }

            Console.WriteLine("Chord Progression:");
            Random rand = new Random();
            for (int i = 0; i < 4; i++)
            {
                int index = rand.Next(allChords.Count);
                Console.WriteLine(allChords[index]);
            }
        }
    }
}
