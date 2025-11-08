using System;
using System.Threading;

class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {}

    public override void Run()
    {
        DoStartingMessage();

        int elapsed = 0;
        while (elapsed < _duration)
        {
            Console.Write("\nBreathe in...");
            _Countdown(4);
            Console.WriteLine();
            elapsed += 4;
            if (elapsed >= _duration) break;

            Console.Write("Breathe out...");
            _Countdown(6);
            Console.WriteLine();
            elapsed += 6;
        }

        DoEndingMessage();
        ActivityTracker.Record(_name);
    }
}