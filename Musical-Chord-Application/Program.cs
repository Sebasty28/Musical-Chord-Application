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

        while (loop)
        {
            Console.Write("Enter Chord Name: ");
            name = Console.ReadLine();

            if (int.TryParse(name, out int input1))
            {
                Console.WriteLine("Invalid Input. Chord name cannot be a number.\n");
                continue;
            }

            Console.Write("Enter Chord Type: ");
            type = Console.ReadLine();

            notes = chordManager.GenerateChordNotes(name, type);

            chordManager.AddChord(name, type, notes);
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

            if (int.TryParse(oldType, out int input2))
            {
                Console.WriteLine("Invalid input. Chord type cannot be a number.\n");
                continue;
            }

            Console.Write("New Chord Name: ");
            newName = Console.ReadLine();

            if (int.TryParse(newName, out int input3))
            {
                Console.WriteLine("Invalid input. New chord name cannot be a number.\n");
                continue;
            }

            Console.Write("New Chord Type: ");
            newType = Console.ReadLine();

            if (int.TryParse(newType, out _))
            {
                Console.WriteLine("Invalid input. New chord type cannot be a number.\n");
                continue;
            }

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


