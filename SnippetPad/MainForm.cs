namespace SnippetPad
{
    public partial class MainForm : Form
    {
        private CancellationTokenSource? cancellationTokenSource;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            toolStripComboBoxLanguage.SelectedIndex = 0;
        }

        /// <summary>
        /// Run button: Start the execution of the snippet of code provided in the UI.
        /// </summary>
        private async void toolStripButtonRun_Click(object sender, EventArgs e)
        {
            cancellationTokenSource = new CancellationTokenSource();
            var ct = cancellationTokenSource.Token;

            SetUIRunning();

            try
            {
                var codeSnippet = textBoxCodeSnippet.Text;
                await RunSnippet(codeSnippet, toolStripComboBoxLanguage.Text, ct);
            }
            catch (OperationCanceledException canceledException)
            {
                textBoxExecutionResult.AppendText($"Attention: {canceledException.Message}");
            }
            catch (Exception ex)
            {
                textBoxExecutionResult.AppendText($"Error: {ex.Message}");
            }
            finally
            {
                SetUIStopped();
            }
        }

        /// <summary>
        /// Creates an async task to run the snippet of code provided.
        /// </summary>
        /// <param name="codeSnippet">The snippet of code that we want to run.</param>
        /// <param name="language">The language selected.</param>
        /// <param name="ct">A cancellation token that we can use to stop execution.</param>
        /// <returns></returns>
        private async Task RunSnippet(string codeSnippet, string language, CancellationToken ct)
        {
            var progress = new Progress<string>();
            progress.ProgressChanged += (s, msg) =>
            {
                // Update the result on progress
                textBoxExecutionResult.AppendText($"{msg}{Environment.NewLine}");
            };

            await Task.Run(async () =>
            {
                await Runner.RunSnippet(codeSnippet, language, progress, ct);
            }, ct);
        }

        /// <summary>
        /// Set the state of controls as they should be when executing a snippet
        /// </summary>
        private void SetUIRunning()
        {
            toolStripButtonRun.Enabled = false;
            toolStripButtonStop.Enabled = true;
            toolStripComboBoxLanguage.Enabled = false;
            textBoxExecutionResult.Text = string.Empty;
        }

        /// <summary>
        /// Set the state of controls as they should be after stopping the execution of a snippet
        /// </summary>
        private void SetUIStopped()
        {
            toolStripButtonRun.Enabled = true;
            toolStripButtonStop.Enabled = false;
            toolStripComboBoxLanguage.Enabled = true;
        }

        /// <summary>
        /// Stop button: Cancels the snippet execution task and sets the UI accordingly.
        /// </summary>
        private void toolStripButtonStop_Click(object sender, EventArgs e)
        {
            cancellationTokenSource?.Cancel();
            SetUIStopped();
        }

        /// <summary>
        /// New button: Stops any executing snippet and resets the UI
        /// </summary>
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripButtonStop_Click(sender, e);
            textBoxCodeSnippet.Text = string.Empty;
            textBoxExecutionResult.Text = string.Empty;
        }

        #region Open/save

        /// <summary>
        /// Open button: Launch an open file dialog.
        /// </summary>
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripButtonStop_Click(sender, e);
            openFileDialog.Multiselect = false;
            openFileDialog.FileName = $"snippet.{GetExtension(toolStripComboBoxLanguage.Text)}";
            openFileDialog.Filter = GetFileFilter(toolStripComboBoxLanguage.Text);
            openFileDialog.Title = $"Open {toolStripComboBoxLanguage.Text} File";
            openFileDialog.ShowDialog();
        }

        /// <summary>
        /// OK button in open file dialog.
        /// </summary>
        private void openFileDialog_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            var path = openFileDialog.FileName;
            try
            {
                var content = File.ReadAllText(path);
                textBoxCodeSnippet.Text = content;
            }
            catch (Exception ex)
            {

                MessageBox.Show($"An error occurred opening the snippet:{Environment.NewLine}{ex.Message}");
            }
        }

        /// <summary>
        /// Save button: Launch a save file dialog.
        /// </summary>
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog.FileName = $"snippet.{GetExtension(toolStripComboBoxLanguage.Text)}";
            saveFileDialog.Filter = GetFileFilter(toolStripComboBoxLanguage.Text);
            saveFileDialog.Title = $"Save {toolStripComboBoxLanguage.Text} File";
            saveFileDialog.ShowDialog();
        }

        /// <summary>
        /// OK button in save file dialog.
        /// </summary>
        private void saveFileDialog_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            var path = saveFileDialog.FileName;
            var content = textBoxCodeSnippet.Text;
            try
            {
                File.WriteAllText(path, content);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred saving the snippet:{Environment.NewLine}{ex.Message}");
            }
        }

        /// <summary>
        /// Gets the file extension for the given language.
        /// </summary>
        /// <param name="language">The name of the language.</param>
        /// <returns>The file extension for the given language.</returns>
        private string GetExtension(string language)
        {
            switch (language.ToLower())
            {
                case "csharp":
                    return "cs";
                case "python":
                    return "py";
                case "javascript":
                    return "js";
                case "lua":
                    return "lua";
                default:
                    return "txt";
            }
        }

        /// <summary>
        /// Gets a string containing a value appropriate for use as a file dialog's filter for the given language.
        /// </summary>
        /// <param name="language">The name of the language.</param>
        /// <returns>A file filter for the given language.</returns>
        private string GetFileFilter(string language)
        {
            switch (language.ToLower())
            {
                case "csharp":
                    return "C# files|*.cs|All Files|*.*";
                case "python":
                    return "Python files|*.py|All Files|*.*";
                case "javascript":
                    return "Javascript files|*.js|All Files|*.*";
                case "lua":
                    return "Lua files|*.lua|All Files|*.*";
                default:
                    return "Text files|*.txt|All Files|*.*";
            }
        }

        #endregion Open/save
    }
}