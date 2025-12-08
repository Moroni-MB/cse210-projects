using System;

namespace JarvisModules.Modules
{
public class TimeModule : AssistantModule
{
    public override string GetName()
    {
        return "time";
    }

    public override string Execute(string input = null)
    {
        if (string.IsNullOrWhiteSpace(input))
        {
            return ShowHelp();
        }

        string command = input.Trim().ToLower();

        return command switch
        {
            "now" => GetCurrentTime(),
            "date" => GetCurrentDate(),
            "day" => GetDayOfWeek(),
            "utc" => GetUtcTime(),
            "help" => ShowHelp(),
            _ => $"Unknown time command: {command}. Type 'help' to see options."
        };
    }

    private string GetCurrentTime()
    {
        // DateTime now = DateTime.Now;
        return $"The current time is: {DateTime.Now:hh:mm tt}";
    }

    private string GetCurrentDate()
    {
        // DateTime now = DateTime.Now;
        return $"Today's date: {DateTime.Today:MMMM d, yyyy}";
    }

    private string GetDayOfWeek()
    {
        // DateTime now = DateTime.Now;
        return $"Today is: {DateTime.Today.DayOfWeek}";
    }

    private string GetUtcTime()
    {
        // DateTime now = DateTime.Now;
        return $"UTC time: {DateTime.UtcNow:HH:mm}";
    }

    private string ShowHelp()
    {
        return
        @"Time commands:
  - now   : show current local time
  - date  : show today's date
  - day   : show the day of the week
  - utc   : show current UTC time
  - help  : show this message";
    }
}
}