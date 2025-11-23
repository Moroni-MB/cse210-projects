using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();
        bool running = true;

        while (running)
        {
            Console.WriteLine($"You have {manager.TotalScore} points.\n");
            Console.WriteLine("Menu options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Select a choice from the menu: ");

            try
            {
                int choice = int.Parse(Console.ReadLine() ?? "0");

                switch (choice)
                {
                    case 1:
                        CreateGoal(manager);
                        break;

                    case 2:
                        manager.ListGoals();
                        break;

                    case 3:
                        Console.Write("Enter the file name: ");
                        string saveFile = Console.ReadLine();
                        manager.SaveGoals(saveFile);
                        break;

                    case 4:
                        Console.Write("Enter the file name: ");
                        string loadFile = Console.ReadLine();
                        manager.LoadGoals(loadFile);
                        break;

                    case 5:
                        if (manager.GetGoalCount() == 0)
                        {
                            Console.WriteLine("No goals to record.");
                            break;
                        }

                        manager.ListGoals();
                        Console.Write("Select the number of the goal you completed: ");
                        int goalChoice = int.Parse(Console.ReadLine() ?? "0") - 1;
                        manager.RecordEvent(goalChoice);
                        break;

                    case 6:
                        running = false;
                        Console.WriteLine("Goodbye!");
                        break;

                    default:
                        Console.WriteLine("Please enter a valid number (1-6).");
                        break;
                }
            }
            catch
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }
        }
    }

    static void CreateGoal(GoalManager manager)
    {
        Console.WriteLine("The types of goals are:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Select goal type: ");
        int type = int.Parse(Console.ReadLine());

        Console.Write("Enter the name of the goal: ");
        string name = Console.ReadLine();
        Console.Write("Enter the description of the goal: ");
        string description = Console.ReadLine();
        Console.Write("Enter how many points: ");
        int points = int.Parse(Console.ReadLine());

        switch (type)
        {
            case 1:
                manager.AddGoal(new SimpleGoal(name, description, points));
                break;
            case 2:
                manager.AddGoal(new EternalGoal(name, description, points));
                break;
            case 3:
                Console.Write("Target count for bonus points: ");
                int target = int.Parse(Console.ReadLine());
                Console.Write("Aount of bonus points: ");
                int bonus = int.Parse(Console.ReadLine());
                manager.AddGoal(new ChecklistGoal(name, description, points, bonus, target));
                break;
            default:
                Console.WriteLine("Invalid type.");
                break;
        }
    }
}
