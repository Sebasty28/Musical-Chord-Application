using ChordCommon;
using ChordDAL;
using System;
using System.Collections.Generic;
using static Azure.Core.HttpHeader;

namespace ChordBLL
{
    public class ChordManager
    {
        ChordData chordData = new ChordData();

        public void AddChord(string name, string type, string notes)
        {
            List<Chord> allChords = chordData.GetAllChords();
            bool exists = false;
            foreach (Chord c in allChords)
            {
                if (c.Name == name.ToUpper() && c.Type == type.ToUpper() && c.Notes == notes.ToUpper())
                {
                    exists = true;
                    break;
                }
            }

            if (exists)
            {
                Console.WriteLine("Chord already exists!\n");
                return;
            }

            chordData.AddChord(new Chord(name, type, notes));
            Console.WriteLine("Chord added successfully!\n");
        }

        public void EditChord(string oldName, string oldType, string newName, string newType)
        {
            List<Chord> allChords = chordData.GetAllChords();
            Chord originalChord = null;

            foreach (Chord c in allChords)
            {
                if (c.Name.ToUpper() == oldName.ToUpper() && c.Type.ToUpper() == oldType.ToUpper())
                {
                    originalChord = c;
                    break;
                }
            }

            if (originalChord == null)
            {
                Console.WriteLine("Chord not found!\n");
                return;
            }

            string updatedNotes = GenerateChordNotes(newName.ToUpper(), newType.ToUpper());

            Chord updatedChord = new Chord(newName.ToUpper(), newType.ToUpper(), updatedNotes);

            chordData.EditChord(originalChord, updatedChord);

            Console.WriteLine("Chord updated successfully!\n");
        }

        public void DeleteChord(string name, string type)
        {
            List<Chord> allChords = chordData.GetAllChords();
            Chord chordToDelete = null;

            foreach (Chord c in allChords)
            {
                if (c.Name.ToUpper() == name.ToUpper() && c.Type.ToUpper() == type.ToUpper())
                {
                    chordToDelete = c;
                    break;
                }
            }

            if (chordToDelete != null)
            {
                bool removed = chordData.RemoveChord(chordToDelete);
                if (removed)
                {
                    Console.WriteLine("Chord deleted successfully!\n");
                }
                else
                {
                    Console.WriteLine("Chord could not be deleted!\n");
                }
            }
            else
            {
                Console.WriteLine("Chord not found!\n");
            }
        }

        public void SearchChord(string name, string type)
        {
            List<Chord> allChords = chordData.GetAllChords();
            Chord foundChord = null;

            foreach (Chord c in allChords)
            {
                if (c.Name == name.ToUpper() && c.Type == type.ToUpper())
                {
                    foundChord = c;
                    break;
                }
            }

            if (foundChord != null)
                Console.WriteLine("Chord found: " + foundChord);
            else
                Console.WriteLine("Chord not found!\n");
        }

        public void ListAllChords()
        {
            var allChords = chordData.GetAllChords();
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
            var allChords = chordData.GetAllChords();
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

        public string GenerateChordNotes(string root, string type)
        {
            string[] sharpNotes = { "C", "C#", "D", "D#", "E", "F", "F#", "G", "G#", "A", "A#", "B" };
            string[] flatNotes = { "C", "Db", "D", "Eb", "E", "F", "Gb", "G", "Ab", "A", "Bb", "B" };

            string uroot = root.Trim();

            int rootIndex = -1;
            string[] selectedNotes = sharpNotes;

            for (int i = 0; i < 12; i++)
            {
                if (string.Equals(sharpNotes[i], root, StringComparison.OrdinalIgnoreCase))
                {
                    rootIndex = i;
                    selectedNotes = sharpNotes;
                    break;
                }
                else if (string.Equals(flatNotes[i], root, StringComparison.OrdinalIgnoreCase))
                {
                    rootIndex = i;
                    selectedNotes = flatNotes;
                    break;
                }
            }

            if (rootIndex == -1)
                return "Unknown chord";

            List<int> intervals;

            switch (type.ToLower())
            {
                case "major":
                    intervals = new List<int> { 0, 4, 7 };
                    break;
                case "minor":
                    intervals = new List<int> { 0, 3, 7 };
                    break;
                case "7":
                    intervals = new List<int> { 0, 4, 7, 10 };
                    break;
                case "min7":
                    intervals = new List<int> { 0, 3, 7, 10 };
                    break;
                case "maj7":
                    intervals = new List<int> { 0, 4, 7, 11 };
                    break;
                case "sus2":
                    intervals = new List<int> { 0, 2, 7 };
                    break;
                case "sus4":
                    intervals = new List<int> { 0, 5, 7 };
                    break;
                default:
                    return "Unknown chord type";
            }

            List<string> chordNotes = new List<string>();

            for (int i = 0; i < intervals.Count; i++)
            {
                int interval = intervals[i];                    
                int noteIndex = (rootIndex + interval) % 12;   
                string note = selectedNotes[noteIndex];        
                chordNotes.Add(note);                          
            }

            string result = "";
            for (int i = 0; i < chordNotes.Count; i++)
            {
                result += chordNotes[i];

                if (i < chordNotes.Count - 1)
                {
                    result += "-";
                }
            }

            return result;

        }
    }
}
