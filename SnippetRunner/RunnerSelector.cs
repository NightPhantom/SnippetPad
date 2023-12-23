using SnippetRunner.Runners;

namespace SnippetRunner;

internal static class RunnerSelector
{
    internal static Func<string, string> GetSnippetRunner(string language)
    {
        switch (language.ToLower())
        {
            case "csharp":
                return CSharpRunner.RunSnippet;
            case "python":
                return PythonRunner.RunSnippet;
            case "javascript":
                return JavaScriptRunner.RunSnippet;
            default:
                throw new NotSupportedException($"{language} is not a supported language.");
        }
    }
}
