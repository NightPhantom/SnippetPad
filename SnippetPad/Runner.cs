using System.Diagnostics;

namespace SnippetPad;

internal static class Runner
{
    internal static async Task RunSnippet(string snippet, string language, IProgress<string> progress, CancellationToken ct)
    {
        using (Process process = new Process())
        {
            // Configure SnippetRunner process
            process.StartInfo.FileName = "SnippetRunner.exe";
            process.StartInfo.Arguments = $"\"{GetEncodedArgument(snippet)}\" {language}";
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.RedirectStandardError = true;
            process.StartInfo.CreateNoWindow = true;

            // Listen for messages from SnippetRunner
            process.OutputDataReceived += (sender, e) =>
            {
                if (!string.IsNullOrEmpty(e.Data))
                {
                    // Report new message back to UI
                    progress.Report($"{e.Data}");
                }
            };
            process.ErrorDataReceived += (sender, e) =>
            {
                if (!string.IsNullOrEmpty(e.Data))
                {
                    // Report new error back to UI
                    progress.Report($"{e.Data}");
                }
            };

            // Run the process
            process.Start();
            process.BeginOutputReadLine();

            // Register cancellation token to kill the process uif requested
            var ctRegistration = ct.Register(() =>
            {
                if (!process.HasExited)
                {
                    process.Kill();
                }
            });

            // Wait for exit
            await process.WaitForExitAsync(ct);
            ctRegistration.Dispose();
        }
    }

    internal static string GetEncodedArgument(string argument)
    {
        return argument
            .Replace("\"", "\"\"");
    }
}
