using System.Data;

namespace JarvisModules.Modules
{
public class CalculatorModule : AssistantModule
{
    public override string GetName()
    {
        return "calc";
    }

    public override string Execute(string? input)
    {
        if (string.IsNullOrWhiteSpace(input))
        {
            return "Please enter a math expression.";
        }
        return $"Result: {Calculate(input)}";
    }

    private string Calculate(string expression)
    {
        if (string.IsNullOrWhiteSpace(expression))
        {
            return "Input must be a valid expression.";
        }

        try
        {
            var table = new System.Data.DataTable();
            var result = table.Compute(expression, null);

            return result.ToString() ?? "Error computing expression.";
        }
        catch
        {
            return "Invalid expression.";
        }
    }
}
}