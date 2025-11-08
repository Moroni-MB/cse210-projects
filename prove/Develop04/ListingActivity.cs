using System;
using System.Collections.Generic;
using System.Threading;

class ListingActivity : Activity
{
    private string[] prompts = {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity() : base(
        "Listing",
        "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    { }

    public override void Run()
    {
        DoStartingMessage();

        Console.WriteLine("\nList as many responses you can to the following prompt:");
        Random rand = new Random();
        Console.WriteLine($"\n{prompts[rand.Next(prompts.Length)]}");
        Console.Write("You may begin in: ");
        _Countdown(5);
        Console.WriteLine();

        List<string> items = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string item = Console.ReadLine();
            if (!string.IsNullOrEmpty(item)) items.Add(item);
        }

        Console.WriteLine($"\nYou listed {items.Count} items.");
        DoEndingMessage();
        ActivityTracker.Record(_name);
    }
}
