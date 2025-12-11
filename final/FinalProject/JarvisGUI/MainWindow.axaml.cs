using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Input;
using JarvisGUI.Models;
using System.Collections.ObjectModel;

using JarvisModules.Modules;  // <-- core logic (AssistantManager, CommandRouter, modules)

namespace JarvisGUI;

public partial class MainWindow : Window
{
    private ObservableCollection<ChatBubble> ChatMessages { get; } =
        new ObservableCollection<ChatBubble>();

    private readonly AssistantManager _manager;
    private readonly CommandRouter _router;

    public MainWindow()
    {
        InitializeComponent();

        // Connect ItemsControl to message list
        ChatList.ItemsSource = ChatMessages;

        // Register modules
        _manager = new AssistantManager();
        _manager.RegisterModule(new TimeModule());
        _manager.RegisterModule(new ToDoModule());
        _manager.RegisterModule(new CalculatorModule());
        _manager.RegisterModule(new NotesModule());
        _manager.RegisterModule(new SearchModule());

        _router = new CommandRouter(_manager);
    }

    // BUTTON CLICK -> sends message
    private void SendButton_Click(object? sender, RoutedEventArgs e)
    {
        ProcessInput();
    }

    // PRESSING ENTER -> also sends message
    private void InputBox_KeyDown(object? sender, KeyEventArgs e)
    {
        if (e.Key == Key.Enter)
        {
            ProcessInput();     // Call the real method
            e.Handled = true;   // Prevent newline beep
        }
    }

    // Handles sending + receiving messages
    private void ProcessInput()
    {
        string input = InputBox.Text?.Trim() ?? "";
        if (string.IsNullOrWhiteSpace(input))
            return;

        // Add user bubble
        ChatMessages.Add(new ChatBubble
        {
            Message = input,
            Alignment = "Right",
            Background = "#2B7FFF"  // Light blue
        });

        InputBox.Text = "";

        // Route through JARVIS core
        string response = _router.Route(input);

        // Add JARVIS bubble
        ChatMessages.Add(new ChatBubble
        {
            Message = response,
            Alignment = "Left",
            Background = "#333333" // Dark bubble
        });
    }
}
