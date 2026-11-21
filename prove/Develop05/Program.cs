using System.IO;

class Program
{
    static void Main(string[] args)
    {

        string _userChoice;
        int _currentPoints;
        bool _hasLoadedGoals = false;
        List<Goal> _oldGoals = [];
        List<Goal> _currentGoals = [];

        Console.WriteLine("Goal Program");

        do
        {
            List<Goal> allGoals = [];
            allGoals.AddRange(_oldGoals);
            allGoals.AddRange(_currentGoals);

            _currentPoints = 0;
            foreach (Goal goal in allGoals)
            {
                int points = goal.GetPoints();
                _currentPoints += points;
            }
            
            Console.WriteLine();
            Console.WriteLine($"You have {_currentPoints} points.");
            Console.WriteLine();
            DisplayMenu();
            Console.Write("Select a choice from the menu: ");
            _userChoice = Console.ReadLine();

            switch (_userChoice)
            {
                case "1":
                    Console.WriteLine("The types of goals are:");
                    Console.WriteLine("  1. Simple Goal");
                    Console.WriteLine("  2. Eternal Goal");
                    Console.WriteLine("  3. Checklist");

                    string goalChoice;
                    List<string> goalOptions = ["1", "2", "3"];
                    do
                    {
                        Console.Write("Which type of goal would you like to create? ");
                        goalChoice = Console.ReadLine();
                        if (!goalOptions.Contains(goalChoice))
                        {
                            Console.WriteLine("Invalid choice.");
                        }
                    } while (!goalOptions.Contains(goalChoice));

                    Console.Write("What is the name of your goal? ");
                    string goalName = Console.ReadLine();
                    Console.Write("What is a short description of it? ");
                    string goalDescription = Console.ReadLine();

                    bool validInput = false;
                    int goalPoints;
                    do
                    {
                        Console.Write("What is the amount of points associated with this goal? ");
                        string _points = Console.ReadLine();
                        if (! int.TryParse(_points, out goalPoints))
                        {
                            Console.Write("Invalid input. ");
                        }
                        else
                        {
                            validInput = true;
                        }
                    } while (!validInput);
                    

                    if (goalChoice == "1")
                    {
                        SimpleGoal simpleGoal = new SimpleGoal(goalName, goalDescription, goalPoints);
                        _currentGoals.Add(simpleGoal);
                    }
                    else if (goalChoice == "2")
                    {
                        EternalGoal eternalGoal = new EternalGoal(goalName, goalDescription, goalPoints);
                        _currentGoals.Add(eternalGoal);
                    }
                    else if (goalChoice == "3")
                    {
                        validInput = false;
                        int timesDoneGoal;
                        do
                        {
                            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                            string completionGoal = Console.ReadLine();
                            if (! int.TryParse(completionGoal, out timesDoneGoal))
                            {
                                Console.WriteLine("Invalid input. Please enter a positive whole number.");
                            }
                            else
                            {
                                validInput = true;
                            }
                        } while (!validInput);

                        ChecklistGoal checklistGoal = new ChecklistGoal(goalName, goalDescription, goalPoints, timesDoneGoal);
                        _currentGoals.Add(checklistGoal);
                    }

                    break;

                case "2":
                    int counter = 0;
                    Console.WriteLine("Your goals:");
                    Console.WriteLine();
                    foreach (Goal goal in allGoals)
                    {
                        counter += 1;
                        Console.Write($"{counter}: ");
                        goal.ShowDescription();
                    }
                    break;

                case "3":
                    string saveConfirmation;
                    if (! _hasLoadedGoals)
                    {
                        Console.WriteLine("You haven't loaded any previous entries. If you have old entries and you don't load them before saving, they will be erased.");
                        Console.Write("Do you still want to save (yes/no)? ");
                        saveConfirmation = Console.ReadLine();
                    }
                    else
                    {
                        saveConfirmation = "yes";
                    }

                    while (saveConfirmation.ToLower() != "yes" && saveConfirmation.ToLower() != "no")
                    {
                        Console.Write("I can't understand that. Try again (yes/no): ");
                        saveConfirmation = Console.ReadLine();
                    }

                    if (saveConfirmation == "yes" && _currentGoals.Count > 0)
                    {
                        Console.Write("Enter the file you would like to save your entries to: ");
                        string filename = Console.ReadLine();

                        using (StreamWriter writer = new StreamWriter(filename))
                        // I was going to use a for loop here. ChatGPT recommended
                        // the for each loop, which I preferred. 
                        foreach (Goal goal in allGoals)
                        {
                            string saveString = goal.GetSaveString();
                            writer.WriteLine(saveString);
                        }
                    }
                    else if (_currentGoals.Count == 0)
                    {
                        Console.WriteLine("There are no entries to save.");
                    }                
                    break;

                case "4":
                    if (! _hasLoadedGoals)
                    {
                        LoadOldGoals(_oldGoals);
                        _hasLoadedGoals = true;
                    }
                    else
                    {
                        Console.WriteLine("You have already loaded this session.");
                    }
                    break;

                case "5":
                    List<Goal> unfinishedGoals = [];
                    counter = 0;
                    foreach (Goal goal in allGoals)
                    {
                        bool completed = goal.GetCompleted();
                        if (!completed)
                        {
                            counter += 1;
                            string title = goal.GetTitle();
                            Console.WriteLine($"{counter}. {title}");
                            unfinishedGoals.Add(goal);
                        }
                    }
                    int goalIndex;
                    bool validIndex = false;
                    do
                    {
                        Console.Write("Which goal did you accomplish? ");
                        string goalCompleted = Console.ReadLine();

                        if (!int.TryParse(goalCompleted, out goalIndex) || goalIndex > unfinishedGoals.Count())
                        {
                            Console.WriteLine("Invalid input.");
                        }
                        else
                        {
                            validIndex = true;
                        }
                    } while (!validIndex);

                    unfinishedGoals[goalIndex - 1].IncreaseTimesDone();
                   
                    break;

                case "6":

                    break;

                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }

        } while (_userChoice != "6");
    }

    static void DisplayMenu()
    {
        Console.WriteLine("Menu Options:");
        Console.WriteLine("  1. Create New Goal");
        Console.WriteLine("  2. List Goals");
        Console.WriteLine("  3. Save Goals");
        Console.WriteLine("  4. Load Old Goals");
        Console.WriteLine("  5. Record Goal Progress");
        Console.WriteLine("  6. Quit");
    }

    static void LoadOldGoals(List<Goal> oldGoals)
    {
        Console.Write("Enter the file with the goals you would like to load: ");
        string filename = Console.ReadLine();

        bool hasLoadedGoals = false;
        do
        {
            try
            {
                using (StreamReader reader = new StreamReader(filename))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] parts = line.Split("||");
                        string objectType = parts[0];
                        string title = parts[1];
                        string description = parts[2];
                        int points = int.Parse(parts[3]);

                        if (objectType == "SimpleGoal")
                        {
                            bool completionStatus = bool.Parse(parts[4]);
                            SimpleGoal goal = new SimpleGoal(title, description, points, completionStatus);
                            oldGoals.Add(goal);
                        }
                        else if (objectType == "ChecklistGoal")
                        {
                            int timesDone = int.Parse(parts[4]);
                            int timesDoneGoal = int.Parse(parts[5]);
                            ChecklistGoal goal = new ChecklistGoal(title, description, points, timesDone, timesDoneGoal);
                            oldGoals.Add(goal);
                        }
                        else
                        {
                            EternalGoal goal = new EternalGoal(title, description, points);
                            oldGoals.Add(goal);
                        }  
                    }
                }

                hasLoadedGoals = true;
                Console.WriteLine("Load successful!");
            }

            catch (FileNotFoundException)
            {
                Console.Write("File not found. Different filename: ");
                filename = Console.ReadLine();
            }
        } while (!hasLoadedGoals);
    }
}

