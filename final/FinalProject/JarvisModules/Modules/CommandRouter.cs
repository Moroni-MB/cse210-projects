using JarvisModules.Modules;

namespace JarvisModules.Modules
{
    public class CommandRouter
    {
        private readonly AssistantManager _manager;

        public CommandRouter(AssistantManager manager)
        {
            _manager = manager;
        }

        public string Route(string? input)
        {
            // Check if user input is blank
            if (string.IsNullOrWhiteSpace(input))
                return "Please enter a command.";

            // Split input into two parts
            string[] parts = input.Split(' ', 2);

            // Assign the module name fo rthe first part
            string moduleName = parts[0].ToLower();

            // Assign the input for the second part
            string moduleInput = parts.Length > 1 ? parts[1] : null;

            // Pass the module name and input to the manager to execute
            return _manager.ExecuteModule(moduleName, moduleInput);
        }
    }
}