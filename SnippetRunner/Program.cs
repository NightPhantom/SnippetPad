using SnippetRunner;

if (args.Length != 2)
{
    Console.Error.WriteLine("Usage: SnippetRunner <script> <language>");
    return;
}

var snippet = args.First();
var language = args.Last();

try
{
    var runner = RunnerSelector.GetSnippetRunner(language);
    var result = runner(snippet);
    Console.WriteLine($"Return value: {result}");
    return;
}
catch (Exception ex)
{
    Console.Error.WriteLine($"Snippet execution error: {ex.Message}");
}
