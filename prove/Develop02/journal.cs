using System.IO;
class Journal
{
    // attributes
    public List<string> _currentEntries = new List<string>();
    public List<string> _oldEntries = new List<string>();
    List<string> _promptList = new List<string>() 
    {
        "What was I grateful for today?", "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "How can I be more aware of the needs of those around me?",
        "If I had one thing I could do over today, what would it be?",
        "What will I do better tomorrow?", "What am I excited for in life right now?",
        "What music am I enjoying currently?", "What was the strongest emotion I felt today?"
    };
    Random random_index = new Random();

    // behaviors
    public string GetRandomPrompt()
    {
        int index = random_index.Next(_promptList.Count);
        string prompt = _promptList[index];
        return prompt;
    }

    public void DisplayEntries(List<string> oldEntries, List<string> currentEntries)
    {
        string date;
        string prompt;
        string response;
        if (oldEntries.Count > 0)
            for (int i = 0; i < oldEntries.Count; i++)
            {
                string[] entryParts = oldEntries[i].Split("||");
                date = entryParts[0];
                prompt = entryParts[1];
                response = entryParts[2];

                string oldEntry = $"Date: {date} -- Prompt: {prompt}\n{response}\n";
                Console.WriteLine(oldEntry);
            }

        if (currentEntries.Count > 0)
        {
            for (int i = 0; i < currentEntries.Count; i++)
            {
                string[] entryParts = currentEntries[i].Split("||");
                date = entryParts[0];
                prompt = entryParts[1];
                response = entryParts[2];

                string currentEntry = $"Date: {date} -- Prompt: {prompt}\n{response}\n";
                Console.WriteLine(currentEntry);
            }                        
        }        
    }

    public List<string> LoadJournal(string filename, List<string> oldEntries)
    {
        bool loaded = false;
        while (!loaded)
        {
            try
            {
                using (StreamReader reader = new StreamReader(filename))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        // string[] parts = line.Split("||");
                        // string date = parts[0];
                        // string prompt = parts[1];
                        // string response = parts[2];

                        // string oldEntry = $"Date: {date} -- Prompt: {prompt} \n {response}";
                        oldEntries.Add(line);
                    }
                }

                loaded = true;
            }

            catch (FileNotFoundException)
            {
                Console.Write("File not found. Different filename: ");
                filename = Console.ReadLine();
            }

        }
        return oldEntries;
    }

    public void SaveJournal(string filename, List<string> oldEntries, List<string> currentEntries)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            if (oldEntries.Count > 0)
            {
                for (int i = 0; i < oldEntries.Count; i++)
                {
                    writer.WriteLine(oldEntries[i]);
                }
            }

            if (currentEntries.Count > 0)
            {
                for (int i = 0; i < currentEntries.Count; i++)
                {
                    writer.WriteLine(currentEntries[i]);
                }
            }
        }
    }
}