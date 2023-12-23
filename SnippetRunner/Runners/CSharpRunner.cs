using Microsoft.CodeAnalysis.CSharp.Scripting;
using Microsoft.CodeAnalysis.Scripting;

namespace SnippetRunner.Runners;

internal static class CSharpRunner
{
    public static string RunSnippet(string snippet)
    {
        var returnValue = string.Empty;

        try
        {
            var result = CSharpScript.EvaluateAsync(snippet, ScriptOptions.Default);
            returnValue = result?.Result?.ToString() ?? "null";
        }
        catch (CompilationErrorException compilationError)
        {
            returnValue = string.Join(Environment.NewLine, compilationError.Diagnostics);
        }
        catch (Exception ex)
        {
            returnValue = $"Error: {ex.Message}";
        }

        return returnValue;
    }
}
