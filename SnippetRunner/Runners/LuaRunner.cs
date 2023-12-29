using NLua;

namespace SnippetRunner.Runners;

internal class LuaRunner
{
    public static string RunSnippet(string snippet)
    {
        var returnValue = string.Empty;

        try
        {
            using (var lua = new Lua())
            {
                var result = lua.DoString(snippet);
                returnValue = result.FirstOrDefault()?.ToString() ?? "null";
            }
        }
        catch (Exception ex)
        {
            returnValue = $"Error: {ex.Message}";
        }

        return returnValue;
    }
}
