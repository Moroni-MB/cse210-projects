using System;

class Program
{
    static void Main(string[] args)
    {
        AssistantManager manager = new AssistantManager();

        manager.RegisterModule(new TimeModule());
        manager.RegisterModule(new ToDoModule());
        manager.RegisterModule(new CalculatorModule());
        manager.RegisterModule(new NotesModule());
        manager.RegisterModule(new SearchModule());

        CommandRouter router = new CommandRouter(manager);

        Console.WriteLine("JARVIS Console (Type exit to quit)");
        Console.WriteLine("-------------------");

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
