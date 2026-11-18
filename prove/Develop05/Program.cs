using System;

class Program
{
    static void Main(string[] args)
    {

        string _userChoice;
        string _goalChoice;

        do
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Goals");
            Console.WriteLine("  6. Quit");
            Console.Write("Select a choice from the menu: ");
            _userChoice = Console.ReadLine();

            switch (_userChoice)
            {
                case "1":
                    Console.WriteLine("The types of goals are:");
                    Console.WriteLine("  1. Simple Goal");
                    Console.WriteLine("  2. Eternal Goal");
                    Console.WriteLine("  3. Checklist");
                    Console.Write("Which type of goal would you like to create? ");
                    _goalChoice = Console.ReadLine();
                    break;

                case "2":

                    break;

                case "3":

                    break;

                case "4":
                    Console.Write("Enter text file name: ");
                    string filename = Console.ReadLine();
                    break;

                case "5":

                    break;

                case "6":

                    break;

                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        } while (_userChoice != "6");
    }
}