using System.Collections.Generic;

namespace JarvisModules.Modules
{
public class ToDoModule : AssistantModule
{
    private List<string> _tasks = new List<string>();

    public override string GetName()
    {
        return "todo";
    }

    public override string Execute(string? input)
    {
        if (input is null)
        {
            return "Please enter a to-do command.";
        }
        else
        {
            // Splits the input of the user into two parts, the first is the command, and the rest is the action
            string[] parts = input.Split(' ', 2);
            string command = parts[0].ToLower();

            if (command == "add")
            {
                if (parts.Length < 2)
                {
                    return "Please include a task to add.";
                }
                return AddTask(parts[1]);
            }
            else if (command == "remove")
            {
                if (parts.Length < 2)
                {
                    return "Please include a task to remove.";
                }
                return RemoveTask(parts[1]);
            }
            else if (command == "list")
            {
                return DisplayTasks();
            }
            else
            {
                return "Unknown command. Try: add, remove, or list.";
            }
        }
    }

    private string AddTask(string task)
    {
        if (string.IsNullOrWhiteSpace(task))
        {
            return "Task cannot be empty.";
        }
        _tasks.Add(task);

        return $"Added task: {task}";
    }

    private string RemoveTask(string task)
    {
        if (string.IsNullOrWhiteSpace(task))
        {
            return "Please specify a task to remove.";
        }
        if (!_tasks.Contains(task))
        {
            return "Task not found.";
        }
        _tasks.Remove(task);
        return $"Task {task} has been removed.";
    }

    private string DisplayTasks()
    {
        if (_tasks.Count == 0)
        {
            return "Your to-do list is empty.";
        }

        string _listOfTasks = "";

        for (int i = 0; i < _tasks.Count; i++)
        {
            _listOfTasks += $"{i+1}. {_tasks[i]}\n";
        }

        return _listOfTasks;
    }

}
}