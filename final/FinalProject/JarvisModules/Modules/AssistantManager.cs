using System;
using System.Collections.Generic;
using System.Linq;

namespace JarvisModules.Modules
{
public class AssistantManager
{
    private List<AssistantModule> _modules = new List<AssistantModule>();

    public void RegisterModule(AssistantModule module)
    {
        _modules.Add(module);
    }

    public string ExecuteModule(string moduleName, string? input)
    {
        // Finds the module whose name matches what the user asked for
        var module = _modules.FirstOrDefault(m => m.GetName().Equals(moduleName, StringComparison.OrdinalIgnoreCase));

        if (module == null)
        {
            return $"Module '{moduleName}' not found.";
        }
        return module.Execute(input);
    }

    public List<string> GetModules()
    {
        // Return a list of modules in the program
        return _modules.Select(m => m.GetName()).ToList();
    }
}
}