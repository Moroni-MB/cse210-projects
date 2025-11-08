using System;
using System.Threading;

class ReflectingActivity : Activity
{
    private string[] prompts = {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private string[] questions = {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public ReflectingActivity() : base(
        "Reflection",
        "This activity will help you reflect on times in your life when you have shown strength and resilience.")
    { }

    public override void Run()
    {
        DoStartingMessage();

        Random rand = new Random();
        Console.WriteLine($"\nConsider the following prompt:\n\n{prompts[rand.Next(prompts.Length)]}\n");

        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine(); // Wait for the user to press Enter

        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
        Console.Write("You may begin in: ");
        _Countdown(5);

        int elapsed = 0;
        Console.Clear();
        while (elapsed < _duration)
        {
            string question = questions[rand.Next(questions.Length)];
            Console.Write($"\n> {question} ");
            _SpinnerAnimation(5);
            elapsed += 5;
        }

        DoEndingMessage();
        ActivityTracker.Record(_name);
    }
}
