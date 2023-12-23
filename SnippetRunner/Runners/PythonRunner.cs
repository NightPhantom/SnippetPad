namespace SnippetRunner.Runners;

internal class PythonRunner
{
    public static string RunSnippet(string snippet)
    {
        var returnValue = string.Empty;

        try
        {
            var engine = IronPython.Hosting.Python.CreateEngine();
            var scope = engine.CreateScope();
            var script = engine.CreateScriptSourceFromString(snippet);
            var result = script.Execute(scope);
            returnValue = result;
        }
        catch (Exception ex)
        {
            returnValue = $"Error: {ex.Message}";
        }

        return returnValue;
    }
}
