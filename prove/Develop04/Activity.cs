using System;
using System.Threading;

class Activity
{
    public string _name;
    public string _description;
    public int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void DoStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name} Activity!\n");
        Console.WriteLine($"{_description}\n");
        Console.Write($"How long, in seconds, would you like for your session? ");
        
        while (!int.TryParse(Console.ReadLine(), out _duration) || _duration <= 0)
        {
            Console.Write("Please enter a valid positive number for duration: ");
        }
        Console.Clear();
        Console.WriteLine("\nGet ready...");
        _SpinnerAnimation(3);
    }

    public void DoEndingMessage()
    {
        Console.WriteLine("\nWell done!");
        _SpinnerAnimation(3);
        Console.WriteLine();
        Console.WriteLine($"You have completed the {_name} Activity for {_duration} seconds.");
        _SpinnerAnimation(3);
        Console.WriteLine();
        
        Console.Clear();
    }

    protected void _SpinnerAnimation(int duration = 5)
    {
        string[] spinner = { "/", "-", "\\", "|" };
        int totalSteps = duration * 4; // 4 steps per second

        for (int i = 0; i < totalSteps; i++)
        {
            Console.Write(spinner[i % spinner.Length]);
            Thread.Sleep(250);
            Console.Write("\b"); // erase the spinner character
        }

        // Clear the spinner after finishing
        Console.Write(" ");  // overwrite spinner with space
        Console.Write("\b"); // move cursor back
    }

    protected void _Countdown(int seconds)
    {
        for (int i = seconds; i >= 1; i--)
        {
            string numStr = i.ToString();
            Console.Write(numStr);
            Thread.Sleep(1000);

            // Erase all characters of the number
            Console.Write(new string('\b', numStr.Length));
            Console.Write(new string(' ', numStr.Length)); // overwrite with spaces
            Console.Write(new string('\b', numStr.Length)); // move cursor back
        }
    }

    public virtual void Run() {}
}