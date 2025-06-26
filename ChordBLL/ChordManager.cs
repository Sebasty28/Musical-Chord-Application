using System;
using System.Collections.Generic;
using ChordCommon;
using ChordDAL;

namespace ChordBLL
{
    public class ChordManager
    {
        ChordData chordData = new ChordData();

        public bool AddChord(string name, string type, string notes)
        {
            List<Chord> allChords = chordData.GetAllChords();

            for (int i = 0; i < allChords.Count; i++)
            {
                Chord c = allChords[i];
                if (c.Name.ToUpper() == name.ToUpper() &&
                    c.Type.ToUpper() == type.ToUpper() &&
                    c.Notes.ToUpper() == notes.ToUpper())
                {
                    return false; //If chord already exists
                }
            }

            chordData.AddChord(new Chord(name.ToUpper(), type.ToLower(), notes.ToUpper()));
            return true;
        }

        public bool EditChord(string oldName, string oldType, string newName, string newType, out string updatedNotes)
        {
            updatedNotes = null;
            List<Chord> allChords = chordData.GetAllChords();
            Chord originalChord = null;

            for (int i = 0; i < allChords.Count; i++)
            {
                Chord c = allChords[i];
                if (c.Name.ToUpper() == oldName.ToUpper() &&
                    c.Type.ToUpper() == oldType.ToUpper())
                {
                    originalChord = c;
                    break;
                }
            }

            if (originalChord == null)
                return false;

            for (int i = 0; i < allChords.Count; i++)
            {
                Chord c = allChords[i];
                if (c.Name.ToUpper() == newName.ToUpper() &&
                    c.Type.ToLower() == newType.ToLower())
                {
                    if (c != originalChord)
                    {
                        updatedNotes = null;
                        return false; //If chord already exists
                    }
                }
            }

            updatedNotes = GenerateChordNotes(newName.ToUpper(), newType.ToLower());
            Chord updatedChord = new Chord(newName.ToUpper(), newType.ToLower(), updatedNotes.ToUpper());
            chordData.EditChord(originalChord, updatedChord);
            return true;
        }

        public bool DeleteChord(string name, string type)
        {
            List<Chord> allChords = chordData.GetAllChords();
            Chord chordToDelete = null;

            for (int i = 0; i < allChords.Count; i++)
            {
                Chord c = allChords[i];
                if (c.Name.ToUpper() == name.ToUpper() &&
                    c.Type.ToUpper() == type.ToUpper())
                {
                    chordToDelete = c;
                    break;
                }
            }

            if (chordToDelete != null)
            {
                return chordData.RemoveChord(chordToDelete);
            }

            return false;
        }

        public Chord SearchChord(string name, string type)
        {
            List<Chord> allChords = chordData.GetAllChords();

            for (int i = 0; i < allChords.Count; i++)
            {
                Chord c = allChords[i];
                if (c.Name.ToUpper() == name.ToUpper() &&
                    c.Type.ToUpper() == type.ToUpper())
                {
                    return c;
                }
            }

            return null;
        }

        public List<Chord> GetAllChords()
        {
            return chordData.GetAllChords();
        }

        public List<Chord> GenerateProgression()
        {
            List<Chord> allChords = chordData.GetAllChords();
            List<Chord> progression = new List<Chord>();

            if (allChords.Count < 4)
                return null;

            Random rand = new Random();
            for (int i = 0; i < 4; i++)
            {
                int index = rand.Next(allChords.Count);
                progression.Add(allChords[index]);
            }

            return progression;
        }

        public string GenerateChordNotes(string root, string type)
        {
            string[] sharpNotes = { "C", "C#", "D", "D#", "E", "F", "F#", "G", "G#", "A", "A#", "B" };
            string[] flatNotes = { "C", "Db", "D", "Eb", "E", "F", "Gb", "G", "Ab", "A", "Bb", "B" };

            root = root.Trim().ToUpper();
            int rootIndex = -1;
            string[] selectedNotes = sharpNotes;

            for (int i = 0; i < 12; i++)
            {
                if (sharpNotes[i].ToUpper() == root)
                {
                    rootIndex = i;
                    selectedNotes = sharpNotes;
                    break;
                }
                else if (flatNotes[i].ToUpper() == root)
                {
                    rootIndex = i;
                    selectedNotes = flatNotes;
                    break;
                }
            }

            if (rootIndex == -1)
                return "Unknown chord";

            List<int> intervals = null;
            string lowerCaseType = type.ToLower();

            if (lowerCaseType == "major")
            {
                intervals = new List<int> { 0, 4, 7 };
            }
            else if (lowerCaseType == "minor")
            {
                intervals = new List<int> { 0, 3, 7 };
            }
            else if (lowerCaseType == "7")
            {
                intervals = new List<int> { 0, 4, 7, 10 };
            }
            else if (lowerCaseType == "min7" || lowerCaseType == "minor7")
            {
                intervals = new List<int> { 0, 3, 7, 10 };
            }
            else if (lowerCaseType == "maj7" || lowerCaseType == "major7")
            {
                intervals = new List<int> { 0, 4, 7, 11 };
            }
            else if (lowerCaseType == "sus2")
            {
                intervals = new List<int> { 0, 2, 7 };
            }
            else if (lowerCaseType == "sus4")
            {
                intervals = new List<int> { 0, 5, 7 };
            }
            else if (lowerCaseType == "add9")
            {
                intervals = new List<int> { 0, 4, 7, 1 };
            }
            else if (lowerCaseType == "dim" || lowerCaseType == "diminished") 
            {
                intervals = new List<int> { 0, 3, 6 };
            }
            else if (lowerCaseType == "dim7" || lowerCaseType == "diminished7")
            {
                intervals = new List<int> { 0, 3, 6, 9 };
            }
            else if (lowerCaseType == "m7b5" || lowerCaseType == "half-diminished")
            {
                intervals = new List<int> { 0, 3, 6, 10 };
            }
            else if (lowerCaseType == "aug" || lowerCaseType == "augmented")
            {
                intervals = new List<int> { 0, 4, 8 };
            }
            else if (lowerCaseType == "6")
            {
                intervals = new List<int> { 0, 4, 7, 9 };
            }
            else if (lowerCaseType == "min6" || lowerCaseType == "minor6")
            {
                intervals = new List<int> { 0, 3, 7, 9 };
            }
            else if (lowerCaseType == "9")
            {
                intervals = new List<int> { 0, 4, 7, 10, 2 };
            }
            else if (lowerCaseType == "maj9" || lowerCaseType == "major9")
            {
                intervals = new List<int> { 0, 4, 7, 11, 2 };
            }
            else if (lowerCaseType == "min9" || lowerCaseType == "minor9")
            {
                intervals = new List<int> { 0, 3, 7, 10, 2 };
            }
            else
            {
                return "Unknown chord type";
            }

            List<string> chordNotes = new List<string>();

            for (int i = 0; i < intervals.Count; i++)
            {
                int interval = intervals[i];
                int noteIndex = (rootIndex + interval) % 12;
                chordNotes.Add(selectedNotes[noteIndex]);
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
