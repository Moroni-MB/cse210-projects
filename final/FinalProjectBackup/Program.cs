using System;

class Program
{
    static void TypeOut(string text, int delay = 20)
    {
        foreach (char c in text)
        {
            Console.Write(c);
            Thread.Sleep(delay);
        }
    }

    static void ShowLoadingAnimation()
    {
        string[] frames = { "|", "/", "-", "\\" };

        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Write("Starting JARVIS ");

        for (int i = 0; i < 20; i++)
        {
            Console.Write(frames[i % frames.Length]);
            Thread.Sleep(80);
            Console.Write("\b"); // erase last character
        }

        Console.ResetColor();
        Console.WriteLine();
    }


    static void ShowWelcomeScreen()
    {
        Console.Clear();

        Console.ForegroundColor = ConsoleColor.Cyan;
        TypeOut("=======================================\n", 3);
        TypeOut("    J A R V I S   A S S I S T A N T    \n", 3);
        TypeOut("=======================================\n\n", 3);
        Console.ResetColor();

        TypeOut("Welcome! I’m JARVIS — your personal assistant.\n", 5);
        TypeOut("Here are some commands I can do right now:\n\n", 5);

        Console.ForegroundColor = ConsoleColor.Yellow;
        TypeOut("Time Module\n", 3);
        Console.ResetColor();
        TypeOut("  Command: \"time\" - Get the current date and time\n\n", 2);

        Console.ForegroundColor = ConsoleColor.Yellow;
        TypeOut("To-Do Module\n", 3);
        Console.ResetColor();
        TypeOut("  Command: \"todo add <text>\" - Add a task\n", 2);
        TypeOut("  Command: \"todo list\" - See your tasks\n\n", 2);

        Console.ForegroundColor = ConsoleColor.Yellow;
        TypeOut("Calculator Module\n", 3);
        Console.ResetColor();
        TypeOut("  Command: \"calc <expression>\" - Quick math\n\n", 2);

        Console.ForegroundColor = ConsoleColor.Yellow;
        TypeOut("Notes Module\n", 3);
        Console.ResetColor();
        TypeOut("  Command: \"note add <text>\" - Save a note\n", 2);
        TypeOut("  Command: \"note list\" - View notes\n\n", 2);

        Console.ForegroundColor = ConsoleColor.Yellow;
        TypeOut("Search Module\n", 3);
        Console.ResetColor();
        TypeOut("  Command: \"search <text>\" - Mock search engine\n\n", 2);

        Console.ForegroundColor = ConsoleColor.Cyan;
        TypeOut("How to Use JARVIS\n", 3);
        Console.ResetColor();
        TypeOut("You can type natural commands or direct module commands.\n\n", 2);

        Console.ForegroundColor = ConsoleColor.Green;
        TypeOut("Examples:\n", 2);
        Console.ResetColor();

        TypeOut("  - \"time help\"\n", 2);
        TypeOut("  - \"todo add buy groceries\"\n", 2);
        TypeOut("  - \"calc 5 * 12 + 3\"\n", 2);
        TypeOut("  - \"note add Remember this.\"\n", 2);
        TypeOut("  - \"search python classes\"\n\n", 2);

        Console.ForegroundColor = ConsoleColor.DarkGray;
        TypeOut("Tip: Type \"exit\" anytime to quit.\n\n", 2);
        Console.ResetColor();

        TypeOut("Type a command below to get started!\n", 5);
        TypeOut("---------------------------------------\n\n", 3);
    }


    static void Main(string[] args)
    {
        AssistantManager manager = new AssistantManager();

        manager.RegisterModule(new TimeModule());
        manager.RegisterModule(new ToDoModule());
        manager.RegisterModule(new CalculatorModule());
        manager.RegisterModule(new NotesModule());
        manager.RegisterModule(new SearchModule());

        CommandRouter router = new CommandRouter(manager);

        ShowLoadingAnimation();
        ShowWelcomeScreen();

        while (true)
        {
            Console.Write("> ");
            string input = Console.ReadLine();

            if (input == "exit")
                break;

            Console.WriteLine(router.Route(input));
        }
    }
}
