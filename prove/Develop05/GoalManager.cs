using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals;
    private int _totalScore;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _totalScore = 0;
    }

    public int TotalScore => _totalScore;

    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    public void ListGoals()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals created yet.");
            return;
        }

        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetStatusString()}");
        }
    }

    public void SaveGoals(string fileName)
    {
        using (StreamWriter output = new StreamWriter(fileName))
        {
            output.WriteLine(_totalScore);
            foreach (Goal g in _goals)
            {
                output.WriteLine(g.SaveGoal());
            }
        }
        Console.WriteLine("Goals saved!");
    }

    public void LoadGoals(string fileName)
    {
        if (!File.Exists(fileName))
        {
            Console.WriteLine("File not found.");
            return;
        }

        string[] lines = File.ReadAllLines(fileName);
        _goals.Clear();

        _totalScore = int.Parse(lines[0]);

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split('|');

            switch (parts[0])
            {
                case "Simple Goal":
                    var s = new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]));
                    s.SetComplete(bool.Parse(parts[4]));
                    _goals.Add(s);
                    break;

                case "Eternal Goal":
                    var e = new EternalGoal(parts[1], parts[2], int.Parse(parts[3]));
                    _goals.Add(e);
                    break;

                case "Checklist Goal":
                    var cg = new ChecklistGoal(
                        parts[1],
                        parts[2],
                        int.Parse(parts[3]),
                        int.Parse(parts[6]),  // bonus points
                        int.Parse(parts[4])   // target amount
                    );
                    cg.SetCount(int.Parse(parts[5]));
                    _goals.Add(cg);
                    break;
            }
        }

        Console.WriteLine("Goals loaded!");
    }

    public void RecordEvent(int goalIndex)
    {
        if (goalIndex < 0 || goalIndex >= _goals.Count)
        {
            Console.WriteLine("Invalid goal selection.");
            return;
        }

        Goal selectedGoal = _goals[goalIndex];

        if (selectedGoal.IsComplete)
        {
            Console.WriteLine("This goal is already complete. No points awarded.");
            return;
        }

        selectedGoal.CompleteGoal();
        int earnedPoints = selectedGoal.CalculatePoints();
        _totalScore += earnedPoints;

        Console.WriteLine($"Congratulations! You earned {earnedPoints} points! \nTotal score: {_totalScore}\n");
    }

    public int GetGoalCount() => _goals.Count;
}
