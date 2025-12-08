using System.Diagnostics;

namespace JarvisModules.Modules
{

public class SearchModule : AssistantModule
{
    public override string GetName()
    {
        return "search";
    }

    public override string Execute(string input)
    {
        if (string.IsNullOrWhiteSpace(input))
        {
            return "Please provide a valid search.";
        }

        return PerformSearch(input);
    }

    private string PerformSearch(string query)
    {
        try
        {
            string url = "https://www.google.com/search?q=" + Uri.EscapeDataString(query);

            Process.Start(new ProcessStartInfo
            {
                FileName = url,
                UseShellExecute = true
            });

            return $"Searching Google for: {query}";
        }
        catch (Exception ex)
        {
            return $"Error performing search: {ex.Message}";
        }
    }
}
}