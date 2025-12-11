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
            if (string.IsNullOrWhiteSpace(input))
                return "Please enter a command.";

            string[] parts = input.Split(' ', 2);

            string moduleName = parts[0].ToLower();
            string moduleInput = parts.Length > 1 ? parts[1] : null;

            return _manager.ExecuteModule(moduleName, moduleInput);
        }
    }
}