using System;
using ChordBLL;
using ChordCommon;

namespace MusicalChordApplication
{
    internal class Program
    {
        static ChordManager chordManager = new ChordManager();

        static string[] menuAction = {
            "[1] Add Chord",
            "[2] Edit Chord",
            "[3] Search Chord",
            "[4] Delete Chord",
            "[5] Show All Chords",
            "[6] Generate Chord Progression",
            "[7] Exit"
        };

        static void Main(string[] args)
        {
            bool loop = true;

            while (loop)
            {
                DisplayMenuAction();

                Console.Write("Choose Action: ");
                string userInput = Console.ReadLine();

                int userAction;
                if (!int.TryParse(userInput, out userAction))
                {
                    Console.WriteLine("Invalid input. Please enter a number.\n");
                    continue;
                }

                if (userAction < 1 || userAction > 7)
                {
                    Console.WriteLine("Error. Choose only from [1] to [7].\n");
                    continue;
                }

                switch (userAction)
                {
                    case 1:
                        AddChord();
                        break;
                    case 2:
                        EditChord();
                        break;
                    case 3:
                        SearchChord();
                        break;
                    case 4:
                        DeleteChord();
                        break;
                    case 5:
                        ListAllChord();
                        break;
                    case 6:
                        GenerateChordProgression();
                        break;
                    case 7:
                        loop = false;
                        break;
                }
            }
        }

        static void DisplayMenuAction()
        {
            Console.WriteLine("\n-- Musical Chord Application --");
            Console.WriteLine("Actions:");
            for (int i = 0; i < menuAction.Length; i++)
            {
                Console.WriteLine(menuAction[i]);
            }
        }

        static void AddChord()
        {
            string name, type, notes;
            bool loop = true;

            string[] validRoots = {
                "A", "A#", "Bb", "B", "C", "C#", "Db",
                "D", "D#", "Eb", "E", "F", "F#", "Gb",
                "G", "G#", "Ab"
            };

            while (loop)
            {
                Console.Write("Enter Chord Name[C, D, A#, Bb etc...]: ");
                name = Console.ReadLine().Trim();

                if (IsInvalidInput(name))
                {
                    Console.WriteLine("Invalid input. Chord name cannot be a number or empty.\n");
                    continue;
                }

                bool isValidRoots = false;
                for (int i = 0; i < validRoots.Length; i++)
                {
                    if (validRoots[i].ToUpper() == name.ToUpper())
                    {
                        isValidRoots = true;
                        break;
                    }
                }

                if (!isValidRoots)
                {
                    Console.WriteLine("Invalid chord name. Use A to G with optional # or b (e.g., C, F#, Bb).\n");
                    continue;
                }

                Console.Write("Enter Chord Type[Major, minor, sus4, maj7 etc...]: ");
                type = Console.ReadLine().Trim();

                if (string.IsNullOrWhiteSpace(type))
                {
                    Console.WriteLine("Invalid input. Chord type cannot be empty.\n");
                    continue;
                }

                string formattedName = name.ToUpper();
                string formattedType = type.ToLower();

                notes = chordManager.GenerateChordNotes(formattedName, formattedType);
                if (notes == "Unknown chord" || notes == "Unknown chord type")
                {
                    Console.WriteLine("Invalid chord type or name. Please try again.\n");
                    continue;
                }

                bool success = chordManager.AddChord(formattedName, formattedType, notes);
                if (success)
                    Console.WriteLine("Chord added successfully!\n");
                else
                    Console.WriteLine("Chord already exists!\n");

                loop = false;
            }
        }

        static void EditChord()
        {
            string oldName, oldType, newName, newType;
            bool loop = true;

            while (loop)
            {
                Console.Write("Enter Chord Name To Edit[C, D, A#, Bb etc...]: ");
                oldName = Console.ReadLine();

                if (IsInvalidInput(oldName))
                {
                    Console.WriteLine("Invalid input. Chord name cannot be a number or empty.\n");
                    continue;
                }

                Console.Write("Enter Chord Type[Major, minor, sus4, maj7 etc...]: ");
                oldType = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(oldType))
                {
                    Console.WriteLine("Invalid input. Chord type cannot be empty.\n");
                    continue;
                }

                Console.Write("New Chord Name[C, D, A#, Bb etc...]: ");
                newName = Console.ReadLine();

                if (IsInvalidInput(newName))
                {
                    Console.WriteLine("Invalid input. New chord name cannot be a number or empty.\n");
                    continue;
                }

                Console.Write("New Chord Type[Major, minor, sus4, maj7 etc...]: ");
                newType = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(newType))
                {
                    Console.WriteLine("Invalid input. Chord type cannot be empty.\n");
                    continue;
                }

                string updatedNotes;
                bool success = chordManager.EditChord(oldName, oldType, newName, newType, out updatedNotes);

                if (success)
                {
                    Console.WriteLine("Chord updated successfully!");
                    Console.WriteLine("New Notes: " + updatedNotes + "\n");
                }
                else
                {
                    Console.WriteLine("Chord not found or the chord already exists!\n");
                }

                loop = false;
            }
        }

        static void DeleteChord()
        {
            Console.Write("Enter Chord Name To Delete[C, D, A#, Bb etc...]: ");
            string name = Console.ReadLine();

            if (IsInvalidInput(name))
            {
                Console.WriteLine("Invalid input. Chord Name cannot be a number or empty.\n");
            }

            Console.Write("Enter Chord Type[Major, minor, sus4, maj7 etc...]: ");
            string type = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(type))
            {
                Console.WriteLine("Invalid input. Chord type cannot be empty.\n");
            }

            bool deleted = chordManager.DeleteChord(name, type);
            if (deleted)
                Console.WriteLine("Chord deleted successfully!\n");
            else
                Console.WriteLine("Chord not found or could not be deleted.\n");
        }

        static void SearchChord()
        {
            Console.Write("Enter Chord Name To Search[C, D, A#, Bb etc...]: ");
            string name = Console.ReadLine();

            if (IsInvalidInput(name))
            {
                Console.WriteLine("Invalid input. Chord Name cannot be a number or empty.\n");
            }

            Console.Write("Enter Chord Type To Search[Major, minor, sus4, maj7 etc...]: ");
            string type = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(type))
            {
                Console.WriteLine("Invalid input. Chord type cannot be empty.\n");
            }

            Chord result = chordManager.SearchChord(name, type);
            if (result != null)
                Console.WriteLine("Chord found: " + result + "\n");
            else
                Console.WriteLine("Chord not found!\n");
        }

        static void ListAllChord()
        {
            var chords = chordManager.GetAllChords();
            if (chords.Count == 0)
            {
                Console.WriteLine("No chords available.\n");
                return;
            }

            Console.WriteLine("\nAll Chords:");
            for (int i = 0; i < chords.Count; i++)
            {
                Console.WriteLine(chords[i]);
            }
            Console.WriteLine();
        }

        static void GenerateChordProgression()
        {
            var chordProgression = chordManager.GenerateProgression();
            if (chordProgression == null || chordProgression.Count < 4)
            {
                Console.WriteLine("Not enough chords to generate a progression.\n");
                return;
            }

            Console.WriteLine("\nGenerated Chord Progression:");
            for (int i = 0; i < chordProgression.Count; i++)
            {
                Console.WriteLine(chordProgression[i]);
            }
            Console.WriteLine();
        }

        static bool IsInvalidInput(string input)
        {
            return string.IsNullOrWhiteSpace(input) || int.TryParse(input, out int output);
        }
    }
}
