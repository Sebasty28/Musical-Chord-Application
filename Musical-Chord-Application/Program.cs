using System;
using ChordBLL;

namespace MusicalChordApplication;

internal class Program
{
    static string[] menuAction = { "[1]Add Chord",
                                   "[2]Edit Chord",
                                   "[3]Delete Chord",
                                   "[4]Search Chord",
                                   "[5]Show All Chords",
                                   "[6]Generate Chord Progression",
                                   "[7]Exit" };

    static ChordManager chordManager = new ChordManager();

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
                Console.WriteLine("Invalid input. Please enter a valid number.\n");
                continue;
            }

            if (userAction == 0 || userAction > 7) Console.WriteLine("Error. Choose only from [1] to [7]\n");

            switch ((MenuOptions)userAction)
            {
                case MenuOptions.Add:
                    AddChord();
                    break;
                case MenuOptions.Edit:
                    EditChord();
                    break;
                case MenuOptions.Delete:
                    DeleteChord();
                    break;
                case MenuOptions.Search:
                    SearchChord();
                    break;
                case MenuOptions.ViewAll:
                    ListAllChord();
                    break;
                case MenuOptions.GenerateProgression:
                    GenerateChordProgression();
                    break;
                case MenuOptions.Exit:
                    loop = false;
                    break;
            }
        }
    }

    static void DisplayMenuAction()
    {
        Console.WriteLine("-Musical Chord Application-");
        Console.WriteLine("Actions:");

        foreach (var menu in menuAction)
        {
            Console.WriteLine(menu);
        }
    }

    static void AddChord()
    {
        string name, type, notes;
        bool loop = true;

        string[] validRoots = { "A", "A#", "Bb", "B", "C", "C#", "Db",
                                "D", "D#", "Eb", "E", "F", "F#", "Gb",
                                "G", "G#", "Ab"};

        while (loop)
        {
            Console.Write("Enter Chord Name: ");
            name = Console.ReadLine().Trim();

            if (int.TryParse(name, out int input))
            {
                Console.WriteLine("Invalid input. Chord name cannot be a number.\n");
                continue;
            }

            bool isValidRoot = false;
            foreach (string root in validRoots)
            {
                if (root.Equals(name, StringComparison.OrdinalIgnoreCase))
                {
                    isValidRoot = true;
                    break;
                }
            }

            if (!isValidRoot)
            {
                Console.WriteLine("Invalid chord name. Use A to G with optional # or b (e.g., C, F#, Bb).\n");
                continue;
            }

            Console.Write("Enter Chord Type: ");
            type = Console.ReadLine().Trim();

            string formattedName = name.ToUpper();
            string formattedType = type.ToLower();

            notes = chordManager.GenerateChordNotes(formattedName, formattedType);

            if (notes == "Unknown chord" || notes == "Unknown chord type")
            {
                Console.WriteLine("Invalid chord type or name. Please try again.\n");
                continue;
            }

            chordManager.AddChord(formattedName, formattedType, notes);
            loop = false;
        }
    }

    static void EditChord()
    {
        string oldName, oldType, newName, newType;
        bool loop = true;

        while (loop)
        {
            Console.Write("Enter Chord Name To Edit: ");
            oldName = Console.ReadLine();

            if (int.TryParse(oldName, out int input1))
            {
                Console.WriteLine("Invalid input. Chord name cannot be a number.\n");
                continue;
            }

            Console.Write("Enter Chord Type: ");
            oldType = Console.ReadLine();

            Console.Write("New Chord Name: ");
            newName = Console.ReadLine();

            if (int.TryParse(newName, out int input3))
            {
                Console.WriteLine("Invalid input. New chord name cannot be a number.\n");
                continue;
            }

            Console.Write("New Chord Type: ");
            newType = Console.ReadLine();

            chordManager.EditChord(oldName, oldType, newName, newType);
            loop = false;
        }

    }

    static void DeleteChord()
    {
        Console.Write("Enter Chord Name To Delete: ");
        string name = Console.ReadLine();
        Console.Write("Enter Chord type: ");
        string type = Console.ReadLine();

        chordManager.DeleteChord(name, type);
    }

    static void SearchChord()
    {
        Console.Write("Enter Chord Name To Search: ");
        string name = Console.ReadLine();
        Console.Write("Enter Chord Type To Search: ");
        string type = Console.ReadLine();

        chordManager.SearchChord(name, type);
    }

    static void ListAllChord()
    {
        chordManager.ListAllChords();
    }

    static void GenerateChordProgression()
    {
        chordManager.GenerateProgression();
    }

}


