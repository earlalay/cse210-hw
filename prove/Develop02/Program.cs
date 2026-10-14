using System;

class Program
{
    static void Main(string[] args)
    {
        int userChoice;
        string prompt = "";
        string response = "";
        Journal journal = new Journal();
        Entry entry = new Entry(prompt, response);
        List<string> currentEntries = new List<string>();
        List<string> oldEntries = new List<string>();
        bool hasSaved = false;
        bool hasLoaded = false;
        string filename;

        do
        {
            DisplayMenu();
            // Get a valid choice from the user
            userChoice = GetValidChoice();

            switch (userChoice)
            {
                case 1:
                    // Give the user a prompt and save their response.
                    prompt = journal.GetRandomPrompt();
                    Console.WriteLine(prompt);
                    response = Console.ReadLine();
                    // Format the entry and save it with the current entries.
                    Entry newEntry = new Entry(prompt, response);
                    string formattedEntry = entry.FormatEntry(newEntry);
                    currentEntries = journal._currentEntries;
                    currentEntries.Add(formattedEntry);
                    break;

                case 2:
                    journal.DisplayEntries(oldEntries, currentEntries);
                    break;

                case 3:
                    if (! hasLoaded)
                    {
                        Console.Write("Enter the file with the entries you would like to load: ");
                        filename = Console.ReadLine();
                        oldEntries = journal._oldEntries;
                        oldEntries = journal.LoadJournal(filename, oldEntries);
                        hasLoaded = true;
                    }

                    else
                    {
                        Console.WriteLine("You have already loaded this session.");
                    }
                    break;

                case 4:
                    string saveConfirmation;
                    if (! hasLoaded)
                    {
                        Console.WriteLine("You haven't loaded any previous entries. If you have old entries and you don't load them before saving, they will be erased.");
                        Console.Write("Do you still want to save (yes/no)? ");
                        saveConfirmation = Console.ReadLine();
                    }
                    else
                    {
                        saveConfirmation = "yes";
                    }

                    while (saveConfirmation != "yes" && saveConfirmation != "no")
                    {
                        Console.Write("I can't understand that. Try again (yes/no): ");
                        saveConfirmation = Console.ReadLine();
                    }

                    if (saveConfirmation == "yes" && currentEntries.Count > 0)
                    {
                        Console.Write("Enter the file you would like to save your entries to: ");
                        filename = Console.ReadLine();
                        journal.SaveJournal(filename, oldEntries, currentEntries);
                        hasSaved = true;
                    }
                    else if (currentEntries.Count == 0)
                    {
                        Console.WriteLine("There are no entries to save.");
                    }                
                    break;
                
                case 5:
                    // Quit the program after checking with the user                
                    string quitConfirmation;
                    if (! hasSaved)
                    {
                        Console.Write("You haven't saved any entries today. Would you still like to quit (yes/no)? ");
                        quitConfirmation = Console.ReadLine();
                    }
                    else
                    {
                        quitConfirmation = "yes";
                    }

                    while (quitConfirmation != "yes" && quitConfirmation != "no")
                    {
                        Console.WriteLine("What was that? Try again (yes/no): ");
                        quitConfirmation = Console.ReadLine();
                    }

                    if (quitConfirmation == "no")
                    {
                        userChoice = 0;
                    }
                    break;
            }
        } while (userChoice != 5);
    }

    public static void DisplayMenu()
    {
        Console.WriteLine("Please choose:");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
    }

    static int GetValidChoice()
    {
        // Get a valid choice from the user
        Console.Write("What would you like to do? ");
        string response = Console.ReadLine();
        int choice = 0;
        while (! int.TryParse(response, out choice) 
                || choice > 5 || choice < 1)
        {
            Console.Write("Invalid choice. Try again: ");
            response = Console.ReadLine();
        }

        return choice;
    }
}

// use @" ... " like a """ in python
