using System;

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
    static void Main(string[] args)
    {
        List<string> listChordName = new List<string>();
        List<string> listChordType = new List<string>();

        bool loop = true;

        while (loop)
        {
            DisplayMenuAction();

            Console.Write("Choose Action: ");
            int userAction = Convert.ToInt32(Console.ReadLine());

            if (userAction == 0 || userAction > 7) Console.WriteLine("Error. Choose only from [1] to [7]\n");

            switch (userAction)
            {
                case 1:
                    AddChord(listChordName, listChordType);
                    break;
                case 2:
                    EditChord(listChordName, listChordType);
                    break;
                case 3:
                    DeleteChord(listChordName, listChordType);
                    break;
                case 4:
                    SearchChord(listChordName, listChordType);
                    break;
                case 5:
                    ListAllChord(listChordName, listChordType);
                    break;
                case 6:
                    GenerateChordProgression(listChordName, listChordType);
                    break;
                case 7:
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

    static void AddChord(List<string> chordNames, List<string> chordTypes)
    {
        Console.Write("Enter Chord Name: ");
        string name = Console.ReadLine().ToUpper();
        Console.Write("Enter Chord Type: ");
        string type = Console.ReadLine().ToUpper();
        chordNames.Add(name);
        chordTypes.Add(type);
        Console.WriteLine("Chord Added Successfully!\n");
    }

    static void EditChord(List<string> chordNames, List<string> chordTypes)
    {
        Console.Write("Enter Chord Name To Edit: ");
        string oldName = Console.ReadLine().ToUpper();

        int index = chordNames.IndexOf(oldName);
        if (index != -1)
        {
            Console.Write("New Chord Name: ");
            string newName = Console.ReadLine().ToUpper();
            Console.Write("New Chord Type: ");
            string newType = Console.ReadLine().ToUpper();
            chordNames[index] = newName;
            chordTypes[index] = newType;
            Console.WriteLine("Chord Updated Successfully!\n");
        }
        else
        {
            Console.WriteLine("Chord Not Found!\n");
        }
    }

    static void DeleteChord(List<string> chordNames, List<string> chordTypes)
    {
        Console.Write("Enter Chord Name To Delete: ");
        string name = Console.ReadLine().ToUpper();

        int index = chordNames.IndexOf(name);
        if (index != -1)
        {
            chordNames.RemoveAt(index);
            chordTypes.RemoveAt(index);
            Console.WriteLine("Chord Deleted Successfully!\n");
        }
        else
        {
            Console.WriteLine("Chord Not Found!\n");
        }
    }

    static void SearchChord(List<string> chordNames, List<string> chordTypes)
    {
        Console.Write("Enter Chord Name To Search: ");
        string name = Console.ReadLine().ToUpper();

        int index = chordNames.IndexOf(name);
        if (index != -1)
        {
            Console.WriteLine($"Chord Found: {chordNames[index]} - {chordTypes[index]}");
        }
        else
        {
            Console.WriteLine("Chord Not found!\n");
        }
    }

    static void ListAllChord(List<string> chordNames, List<string> chordTypes)
    {
        if (chordNames.Count == 0)
        {
            Console.WriteLine("No Chords Available!\n");
            return;
        }

        Console.WriteLine("List of All Chords:");
        for (int i = 0; i < chordNames.Count; i++)
        {
            Console.WriteLine($"{chordNames[i]} ({chordTypes[i]})");
        }
        Console.WriteLine("");
    }

    static void GenerateChordProgression(List<string> chordNames, List<string> chordTypes)
    {
        if (chordNames.Count == 0)
        {
            Console.WriteLine("No Chords Available!\n");
            return;
        }
        else if (chordNames.Count < 4)
        {
            Console.WriteLine("Not Enough Chords. Enter a Total of Four Chords!\n");
            return;
        }
        else
        {
            Random randomChords = new Random();

            Console.WriteLine("Chord Progression: ");

            for (int i = 0; i < 4; i++)
            {
                int randomChordName = randomChords.Next(chordNames.Count);
                Console.WriteLine("[" + chordNames[randomChordName] + "]");
            }
            Console.WriteLine("");
        }

    }
}


