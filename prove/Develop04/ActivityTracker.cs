using System;
using System.Collections.Generic;

static class ActivityTracker
{
    private static Dictionary<string, int> _activityCounts = new Dictionary<string, int>();

    public static void Record(string activityName)
    {
        if (_activityCounts.ContainsKey(activityName))
            _activityCounts[activityName]++;
        else
            _activityCounts[activityName] = 1;
    }

    public static void PrintLog()
    {
        Console.WriteLine("\n--- Activity Log ---");
        if (_activityCounts.Count == 0)
        {
            Console.WriteLine("No activities performed yet.");
        }
        else
        {
            foreach (var kvp in _activityCounts)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value} times");
            }
        }
        Console.WriteLine("-------------------\n");
        Console.WriteLine("Press Enter to return to the menu...");
        Console.ReadLine();
    }
}
