public abstract class AssistantModule
{
    // Returns the name of the module
    public abstract string GetName();
    
    // Executes the module's behavior using optional input
    public abstract string Execute(string? input = null);
}