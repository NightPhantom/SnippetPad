using Microsoft.ClearScript.V8;

namespace SnippetRunner.Runners;

internal class JavaScriptRunner
{
    public static string RunSnippet(string snippet)
    {
        var returnValue = string.Empty;

        try
        {
            using (var engine = new V8ScriptEngine())
            {
                var result = engine.Evaluate(snippet);
                returnValue = result?.ToString() ?? "null";
            }
        }
        catch (Exception ex)
        {
            returnValue = $"Error: {ex.Message}";
        }

        return returnValue;
    }
}
