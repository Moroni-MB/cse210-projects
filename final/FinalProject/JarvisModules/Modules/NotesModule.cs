using System.Collections.Generic;

namespace JarvisModules.Modules
{
public class NotesModule : AssistantModule
{
    private List<string> _notes = new List<string>();

    public override string GetName()
    {
        return "note";
    }

    public override string Execute(string? input)
    {
        if (string.IsNullOrWhiteSpace(input))
        {
            return "Please enter a notes command.";
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
                    return "Please include a note to add.";
                }
                return SaveNote(parts[1]);
            }
            else if (command == "clear")
            {
                // if (parts.Length < 2)
                // {
                //     return "Please include a task to remove.";
                // }
                _notes.Clear();
                return "All notes cleared";
            }
            else if (command == "list")
            {
                return DisplayNotes();
            }
            else
            {
                return "Unknown command. Try: add, list, or clear.";
            }
        }
    }

    private string SaveNote(string note)
    {
        if (string.IsNullOrWhiteSpace(note))
        {
            return "Note cannot be empty.";
        }
        _notes.Add(note);

        return $"Saved note: {note}";
    }

    // private string RemoveTask(string task)
    // {
    //     if (string.IsNullOrWhiteSpace(task))
    //     {
    //         return "Please specify a task to remove.";
    //     }
    //     if (!_tasks.Contains(task))
    //     {
    //         return "Task not found.";
    //     }
    //     _tasks.Remove(task);
    //     return $"Task {task} has been removed.";
    // }

    private string DisplayNotes()
    {
        if (_notes.Count == 0)
        {
            return "There are no notes saved.";
        }

        string _listOfNotes = "";

        for (int i = 0; i < _notes.Count; i++)
        {
            _listOfNotes += $"{i+1}. {_notes[i]}\n";
        }

        return _listOfNotes;
    }

}
}