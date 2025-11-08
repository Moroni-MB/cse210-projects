using System;

class Program
{
    static void Main(string[] args)
    {
        bool running = true;

        while (running)
        {
            Console.WriteLine("Menu options:");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflecting activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. View Activity Log");
            Console.WriteLine("5. Quit");
            Console.Write("Select a choice from the menu: ");

            try
            {
                int choice = int.Parse(Console.ReadLine() ?? "0");  // the ?? mean that if the user input is null the program replaces it witha 0 instead.

                switch (choice)
                {
                    case 1:
                        new BreathingActivity().Run();
                        break;
                    case 2:
                        new ReflectingActivity().Run();
                        break;
                    case 3:
                        new ListingActivity().Run();
                        break;
                    case 4:
                        ActivityTracker.PrintLog();
                        break;
                    case 5:
                        running = false;
                        Console.WriteLine("Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Please enter a valid number (1-4).\n");
                        break;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter a valid number (1-4).\n");
            }
        }
    }
}