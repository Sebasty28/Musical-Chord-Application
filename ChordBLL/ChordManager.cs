using ChordCommon;
using ChordDAL;
using System;
using System.Collections.Generic;

namespace ChordBLL
{
    public class ChordManager
    {
        private IChordDataService chordData;

        public ChordManager(IChordDataService chordDataService)
        {
            chordData = chordDataService;
        }

        public void AddChord(string name, string type)
        {
            bool exists = false;
            foreach (Chord c in chordData.GetAll())
            {
                if (c.Name == name.ToUpper() && c.Type == type.ToUpper())
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

            chordData.Add(new Chord(name, type));
            Console.WriteLine("Chord added successfully!\n");
        }

        public void EditChord(string oldName, string oldType, string newName, string newType)
        {
            Chord chordToEdit = null;
            List<Chord> chords = chordData.GetAll();

            foreach (Chord c in chords)
            {
                if (c.Name == oldName.ToUpper() && c.Type == oldType.ToUpper())
                {
                    chordToEdit = c;
                    break;
                }
            }

            if (chordToEdit == null)
            {
                Console.WriteLine("Chord not found!\n");
                return;
            }

            chordToEdit.Name = newName.ToUpper();
            chordToEdit.Type = newType.ToUpper();
            chordData.Save(chords);
            Console.WriteLine("Chord updated successfully!\n");
        }

        public void DeleteChord(string name, string type)
        {
            List<Chord> chords = chordData.GetAll();
            Chord chordToDelete = null;

            foreach (Chord c in chords)
            {
                if (c.Name == name.ToUpper() && c.Type == type.ToUpper())
                {
                    chordToDelete = c;
                    break;
                }
            }

            if (chordToDelete != null)
            {
                chords.Remove(chordToDelete);
                chordData.Save(chords);
                Console.WriteLine("Chord deleted successfully!\n");
            }
            else
            {
                Console.WriteLine("Chord not found!\n");
            }
        }

        public void SearchChord(string name, string type)
        {
            List<Chord> chords = chordData.GetAll();
            Chord foundChord = null;

            foreach (Chord c in chords)
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
            var allChords = chordData.GetAll();
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
            var allChords = chordData.GetAll();
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
