using System;

namespace MusicalChordApplication;

internal class Program
{

    static void Main(string[] args)
    {
        List<string> listChordName = new List<string>();
        List<string> listChordType = new List<string>();

        string[] menuAction = { "[1]Add Chord", "[2]Edit Chord", "[3]Delete Chord", "[4]Search Chord", "[5]Show All Chords", 
                                "[6]Create Chord Progression", "[7]Exit" };

        bool loop = true;

        while (loop)
        {
            Console.WriteLine("-Musical Chord Application-");
            Console.WriteLine("Actions:");
            foreach (var menu in menuAction)
            {
                Console.WriteLine(menu);
            }

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
                    Console.WriteLine("...\n");
                    break;
                case 7:
                    loop = false;
                    break;
            }
        }


        static void AddChord(List<string> names, List<string> types)
        {
            Console.Write("Enter Chord Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter Chord Type: ");
            string type = Console.ReadLine();
            names.Add(name);
            types.Add(type);
            Console.WriteLine("Chord Added Successfully!\n");
        }


        static void EditChord(List<string> names, List<string> types)
        {
            Console.Write("Enter Chord Name To Edit: ");
            string oldName = Console.ReadLine();

            int index = names.IndexOf(oldName);
            if (index != -1)
            {
                Console.Write("New Chord Name: ");
                string newName = Console.ReadLine();
                Console.Write("New Chord Type: ");
                string newType = Console.ReadLine();
                names[index] = newName;
                types[index] = newType;
                Console.WriteLine("Chord Updated Successfully!\n");
            }
            else
            {
                Console.WriteLine("Chord Not Found!\n");
            }
        }


        static void DeleteChord(List<string> names, List<string> types)
        {
            Console.Write("Enter Chord Name To Delete: ");
            string name = Console.ReadLine();

            int index = names.IndexOf(name);
            if (index != -1)
            {
                names.RemoveAt(index);
                types.RemoveAt(index);
                Console.WriteLine("Chord Deleted Successfully!\n");
            }
            else
            {
                Console.WriteLine("Chord Not Found!\n");
            }
        }


        static void SearchChord(List<string> names, List<string> types)
        {
            Console.Write("Enter Chord Name To Search: ");
            string name = Console.ReadLine();

            int index = names.IndexOf(name);
            if (index != -1)
            {
                Console.WriteLine($"Chord Found: {names[index]} - {types[index]}");
            }
            else
            {
                Console.WriteLine("Chord Not found!\n");
            }
        }


        static void ListAllChord(List<string> names, List<string> types)
        {
            if (names.Count == 0)
            {
                Console.WriteLine("No Chords Available!\n");
                return;
            }

            Console.WriteLine("Chord Progression:");
            for (int i = 0; i < names.Count; i++)
            {
                Console.WriteLine($"{names[i]} ({types[i]})");
                Console.WriteLine("");
            }
        }

    }

}
