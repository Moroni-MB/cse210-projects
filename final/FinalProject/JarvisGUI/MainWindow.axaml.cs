using System;
using Avalonia.Controls;
using Avalonia.Interactivity;
using JarvisModules.Modules;

namespace JarvisGUI;

public partial class MainWindow : Window
{
    private AssistantManager _manager;

    public MainWindow()
    {
        InitializeComponent();

        _manager = new AssistantManager();

        // Register all modules (your actual classes)
        _manager.RegisterModule(new TimeModule());
        _manager.RegisterModule(new ToDoModule());
        _manager.RegisterModule(new NotesModule());
        _manager.RegisterModule(new CalculatorModule());
        _manager.RegisterModule(new SearchModule());

        RunButton.Click += OnRunClicked;
    }

    private void OnRunClicked(object? sender, RoutedEventArgs e)
    {
        string input = UserInputBox.Text ?? "";

        if (string.IsNullOrWhiteSpace(input))
        {
            OutputBox.Text = "Please enter a command.";
            return;
        }

        // Extract module name (first word)
        string[] parts = input.Split(' ', 2, StringSplitOptions.RemoveEmptyEntries);

        string moduleName = parts[0];  // e.g. "time"
        string? moduleInput = parts.Length > 1 ? parts[1] : null;

        string result = _manager.ExecuteModule(moduleName, moduleInput);

        OutputBox.Text = result;
    }
}
