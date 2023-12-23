namespace SnippetPad
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            textBoxCodeSnippet = new TextBox();
            textBoxExecutionResult = new TextBox();
            toolStripMain = new ToolStrip();
            toolStripComboBoxLanguage = new ToolStripComboBox();
            toolStripButtonRun = new ToolStripButton();
            toolStripButtonStop = new ToolStripButton();
            menuStripMain = new MenuStrip();
            toolStripMenuItemFile = new ToolStripMenuItem();
            newToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItemHelp = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            statusStripMain = new StatusStrip();
            openFileDialog = new OpenFileDialog();
            saveFileDialog = new SaveFileDialog();
            splitContainer = new SplitContainer();
            toolStripMain.SuspendLayout();
            menuStripMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer).BeginInit();
            splitContainer.Panel1.SuspendLayout();
            splitContainer.Panel2.SuspendLayout();
            splitContainer.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxCodeSnippet
            // 
            textBoxCodeSnippet.AcceptsReturn = true;
            textBoxCodeSnippet.AcceptsTab = true;
            textBoxCodeSnippet.AllowDrop = true;
            textBoxCodeSnippet.Dock = DockStyle.Fill;
            textBoxCodeSnippet.Font = new Font("Lucida Console", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxCodeSnippet.Location = new Point(0, 0);
            textBoxCodeSnippet.Multiline = true;
            textBoxCodeSnippet.Name = "textBoxCodeSnippet";
            textBoxCodeSnippet.ScrollBars = ScrollBars.Both;
            textBoxCodeSnippet.Size = new Size(919, 323);
            textBoxCodeSnippet.TabIndex = 1;
            // 
            // textBoxExecutionResult
            // 
            textBoxExecutionResult.Dock = DockStyle.Fill;
            textBoxExecutionResult.Font = new Font("Lucida Console", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxExecutionResult.Location = new Point(0, 0);
            textBoxExecutionResult.Multiline = true;
            textBoxExecutionResult.Name = "textBoxExecutionResult";
            textBoxExecutionResult.ReadOnly = true;
            textBoxExecutionResult.ScrollBars = ScrollBars.Both;
            textBoxExecutionResult.Size = new Size(919, 190);
            textBoxExecutionResult.TabIndex = 2;
            // 
            // toolStripMain
            // 
            toolStripMain.GripStyle = ToolStripGripStyle.Hidden;
            toolStripMain.Items.AddRange(new ToolStripItem[] { toolStripComboBoxLanguage, toolStripButtonRun, toolStripButtonStop });
            toolStripMain.Location = new Point(0, 24);
            toolStripMain.Name = "toolStripMain";
            toolStripMain.Size = new Size(919, 25);
            toolStripMain.TabIndex = 3;
            toolStripMain.Text = "toolStrip1";
            // 
            // toolStripComboBoxLanguage
            // 
            toolStripComboBoxLanguage.DropDownStyle = ComboBoxStyle.DropDownList;
            toolStripComboBoxLanguage.FlatStyle = FlatStyle.Standard;
            toolStripComboBoxLanguage.Items.AddRange(new object[] { "CSharp", "JavaScript", "Python" });
            toolStripComboBoxLanguage.Name = "toolStripComboBoxLanguage";
            toolStripComboBoxLanguage.Size = new Size(121, 25);
            toolStripComboBoxLanguage.Sorted = true;
            // 
            // toolStripButtonRun
            // 
            toolStripButtonRun.Image = (Image)resources.GetObject("toolStripButtonRun.Image");
            toolStripButtonRun.ImageTransparentColor = Color.Magenta;
            toolStripButtonRun.Name = "toolStripButtonRun";
            toolStripButtonRun.Size = new Size(48, 22);
            toolStripButtonRun.Text = "Run";
            toolStripButtonRun.Click += toolStripButtonRun_Click;
            // 
            // toolStripButtonStop
            // 
            toolStripButtonStop.Enabled = false;
            toolStripButtonStop.Image = (Image)resources.GetObject("toolStripButtonStop.Image");
            toolStripButtonStop.ImageTransparentColor = Color.Magenta;
            toolStripButtonStop.Name = "toolStripButtonStop";
            toolStripButtonStop.Size = new Size(51, 22);
            toolStripButtonStop.Text = "Stop";
            toolStripButtonStop.Click += toolStripButtonStop_Click;
            // 
            // menuStripMain
            // 
            menuStripMain.Items.AddRange(new ToolStripItem[] { toolStripMenuItemFile, toolStripMenuItemHelp });
            menuStripMain.Location = new Point(0, 0);
            menuStripMain.Name = "menuStripMain";
            menuStripMain.Size = new Size(919, 24);
            menuStripMain.TabIndex = 4;
            menuStripMain.Text = "menuStrip1";
            // 
            // toolStripMenuItemFile
            // 
            toolStripMenuItemFile.DropDownItems.AddRange(new ToolStripItem[] { newToolStripMenuItem, openToolStripMenuItem, saveToolStripMenuItem });
            toolStripMenuItemFile.Name = "toolStripMenuItemFile";
            toolStripMenuItemFile.Size = new Size(37, 20);
            toolStripMenuItemFile.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.Size = new Size(121, 22);
            newToolStripMenuItem.Text = "&New...";
            newToolStripMenuItem.Click += newToolStripMenuItem_Click;
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(121, 22);
            openToolStripMenuItem.Text = "&Open...";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(121, 22);
            saveToolStripMenuItem.Text = "&Save as...";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // toolStripMenuItemHelp
            // 
            toolStripMenuItemHelp.DropDownItems.AddRange(new ToolStripItem[] { aboutToolStripMenuItem });
            toolStripMenuItemHelp.Name = "toolStripMenuItemHelp";
            toolStripMenuItemHelp.Size = new Size(44, 20);
            toolStripMenuItemHelp.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(107, 22);
            aboutToolStripMenuItem.Text = "&About";
            // 
            // statusStripMain
            // 
            statusStripMain.Location = new Point(0, 566);
            statusStripMain.Name = "statusStripMain";
            statusStripMain.Size = new Size(919, 22);
            statusStripMain.TabIndex = 5;
            statusStripMain.Text = "statusStrip1";
            // 
            // openFileDialog
            // 
            openFileDialog.FileOk += openFileDialog_FileOk;
            // 
            // saveFileDialog
            // 
            saveFileDialog.FileOk += saveFileDialog_FileOk;
            // 
            // splitContainer
            // 
            splitContainer.Dock = DockStyle.Fill;
            splitContainer.Location = new Point(0, 49);
            splitContainer.Name = "splitContainer";
            splitContainer.Orientation = Orientation.Horizontal;
            // 
            // splitContainer.Panel1
            // 
            splitContainer.Panel1.Controls.Add(textBoxCodeSnippet);
            // 
            // splitContainer.Panel2
            // 
            splitContainer.Panel2.Controls.Add(textBoxExecutionResult);
            splitContainer.Size = new Size(919, 517);
            splitContainer.SplitterDistance = 323;
            splitContainer.TabIndex = 6;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(919, 588);
            Controls.Add(splitContainer);
            Controls.Add(statusStripMain);
            Controls.Add(toolStripMain);
            Controls.Add(menuStripMain);
            MainMenuStrip = menuStripMain;
            Name = "MainForm";
            Text = "SnippetPad";
            Load += MainForm_Load;
            toolStripMain.ResumeLayout(false);
            toolStripMain.PerformLayout();
            menuStripMain.ResumeLayout(false);
            menuStripMain.PerformLayout();
            splitContainer.Panel1.ResumeLayout(false);
            splitContainer.Panel1.PerformLayout();
            splitContainer.Panel2.ResumeLayout(false);
            splitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer).EndInit();
            splitContainer.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxCodeSnippet;
        private TextBox textBoxExecutionResult;
        private ToolStrip toolStripMain;
        private ToolStripComboBox toolStripComboBoxLanguage;
        private MenuStrip menuStripMain;
        private StatusStrip statusStripMain;
        private ToolStripButton toolStripButtonRun;
        private ToolStripMenuItem toolStripMenuItemFile;
        private ToolStripMenuItem toolStripMenuItemHelp;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripButton toolStripButtonStop;
        private OpenFileDialog openFileDialog;
        private SaveFileDialog saveFileDialog;
        private SplitContainer splitContainer;
    }
}