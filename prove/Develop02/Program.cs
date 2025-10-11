using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();
        bool start = true;

        Console.WriteLine("Welcome to the journal program!");
        
        while (start)
        {
            Console.WriteLine("Please select one of the following choices:\n1.Write\n2.Display\n3.Load\n4.Save\n5.Quit");
            Console.Write("What would you like to do today? ");
            string userEntry = Console.ReadLine();

            // Call the function to write a new journal entry
            // Show the user a random prompt (from a list that you create)
            if (userEntry == "1")
            {
                // Write a new journal entry
                string prompt = promptGenerator.GetPrompt();
                Console.WriteLine($"\n{prompt}");
                Console.Write(">");
                string text = Console.ReadLine();

                string date = DateTime.Now.ToString("MM/dd/yyyy");
                journal.AddEntry(text, date, prompt);

                Console.WriteLine("Entry added!\n");
            }
            // Display entries
            else if (userEntry == "2")
            {
                Console.WriteLine("\nYour journal Entries:");
                journal.DisplayJournal();
            }
            // Load an entry
            else if (userEntry == "3")
            {
                Console.WriteLine("\nEnter the filename to load:");
                string filename = Console.ReadLine();
                journal.LoadFromFile(filename);
            }
            // Save
            else if (userEntry == "4")
            {
                Console.Write("Enter the filename to save: ");
                string filename = Console.ReadLine();
                journal.SaveToFile(filename);
            }
            // Exits the program
            else if (userEntry == "5")
            {
                Console.WriteLine("Thank you for journaling today :)");
                start = false;
            }
            else
            {
                Console.WriteLine("Please pick a number 1-5.\n");
            }
        }
    }
}