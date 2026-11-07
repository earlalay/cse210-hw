using System;

class Program
{
    static void Main(string[] args)
    {
        BreathingAct breathing = new BreathingAct("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.", 0);

        ReflectionAct reflection = new ReflectionAct("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", 0);

        ListingAct listing = new ListingAct("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", 0);

        string _userChoice;

        do
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");
            _userChoice = Console.ReadLine();
            switch (_userChoice)
            {
                case "1":
                    breathing.ShowPrologue();
                    breathing.Run();
                    breathing.ShowEpilogue();
                    break;
                case "2":
                    reflection.ShowPrologue();
                    reflection.Run();
                    reflection.ShowEpilogue();
                    break;
                case "3":
                    listing.ShowPrologue();
                    listing.Run();
                    listing.ShowEpilogue();
                    break;
                case "4":
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    Thread.Sleep(5500);
                    Console.Clear();
                    break;
            }
        } while (_userChoice != "4");
    }
}

