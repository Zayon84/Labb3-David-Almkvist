namespace WinForms_Labb3
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.listsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.countToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.practiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelStart = new System.Windows.Forms.Panel();
            this.createNewListController1 = new WinForms_Labb3.CreateNewListController();
            this.editWordsControl1 = new WinForms_Labb3.EditWordsControl();
            this.practiceWords1 = new WinForms_Labb3.PracticeWords();
            this.userControl11 = new WinForms_Labb3.UserControl1();
            this.menuStrip1.SuspendLayout();
            this.panelStart.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(685, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.toolStripSeparator1,
            this.listsToolStripMenuItem,
            this.EditToolStripMenuItem,
            this.wordsToolStripMenuItem,
            this.countToolStripMenuItem,
            this.practiceToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(113, 6);
            // 
            // listsToolStripMenuItem
            // 
            this.listsToolStripMenuItem.Name = "listsToolStripMenuItem";
            this.listsToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.listsToolStripMenuItem.Text = "Lists";
            this.listsToolStripMenuItem.Click += new System.EventHandler(this.listsToolStripMenuItem_Click);
            // 
            // EditToolStripMenuItem
            // 
            this.EditToolStripMenuItem.Name = "EditToolStripMenuItem";
            this.EditToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.EditToolStripMenuItem.Text = "Edit";
            this.EditToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // wordsToolStripMenuItem
            // 
            this.wordsToolStripMenuItem.Name = "wordsToolStripMenuItem";
            this.wordsToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.wordsToolStripMenuItem.Text = "Words";
            // 
            // countToolStripMenuItem
            // 
            this.countToolStripMenuItem.Name = "countToolStripMenuItem";
            this.countToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.countToolStripMenuItem.Text = "Count";
            // 
            // practiceToolStripMenuItem
            // 
            this.practiceToolStripMenuItem.Name = "practiceToolStripMenuItem";
            this.practiceToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.practiceToolStripMenuItem.Text = "Practice";
            this.practiceToolStripMenuItem.Click += new System.EventHandler(this.practiceToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(113, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // panelStart
            // 
            this.panelStart.Controls.Add(this.createNewListController1);
            this.panelStart.Controls.Add(this.editWordsControl1);
            this.panelStart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelStart.Location = new System.Drawing.Point(0, 24);
            this.panelStart.Margin = new System.Windows.Forms.Padding(2);
            this.panelStart.Name = "panelStart";
            this.panelStart.Size = new System.Drawing.Size(685, 287);
            this.panelStart.TabIndex = 6;
            // 
            // createNewListController1
            // 
            this.createNewListController1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.createNewListController1.Location = new System.Drawing.Point(0, 0);
            this.createNewListController1.Name = "createNewListController1";
            this.createNewListController1.NrOfLanguages = 2;
            this.createNewListController1.Parentform = null;
            this.createNewListController1.Size = new System.Drawing.Size(685, 287);
            this.createNewListController1.TabIndex = 1;
            this.createNewListController1.Visible = false;
            // 
            // editWordsControl1
            // 
            this.editWordsControl1.AutoSize = true;
            this.editWordsControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editWordsControl1.Location = new System.Drawing.Point(0, 0);
            this.editWordsControl1.Name = "editWordsControl1";
            this.editWordsControl1.Parentform = null;
            this.editWordsControl1.Size = new System.Drawing.Size(685, 287);
            this.editWordsControl1.TabIndex = 0;
            this.editWordsControl1.Visible = false;
            // 
            // practiceWords1
            // 
            this.practiceWords1.AutoSize = true;
            this.practiceWords1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.practiceWords1.Location = new System.Drawing.Point(0, 0);
            this.practiceWords1.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.practiceWords1.Name = "practiceWords1";
            this.practiceWords1.NrOfCorrectsAnswers = 0;
            this.practiceWords1.NrOfTries = 0;
            this.practiceWords1.Parentform = null;
            this.practiceWords1.Size = new System.Drawing.Size(1143, 508);
            this.practiceWords1.TabIndex = 1;
            this.practiceWords1.Visible = false;
            this.practiceWords1.WordToPractice = null;
            // 
            // userControl11
            // 
            this.userControl11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControl11.Location = new System.Drawing.Point(0, 0);
            this.userControl11.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.userControl11.Name = "userControl11";
            this.userControl11.Parentform = null;
            this.userControl11.Size = new System.Drawing.Size(1143, 508);
            this.userControl11.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 311);
            this.Controls.Add(this.panelStart);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Labb 3 WordList ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelStart.ResumeLayout(false);
            this.panelStart.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem listsToolStripMenuItem;
        private ToolStripMenuItem EditToolStripMenuItem;
        private ToolStripMenuItem wordsToolStripMenuItem;
        private ToolStripMenuItem countToolStripMenuItem;
        private ToolStripMenuItem practiceToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripSeparator toolStripSeparator2;
        private Panel panelStart;
        private UserControl1 userControl11;
        private PracticeWords practiceWords1;
        private EditWordsControl editWordsControl1;
        private CreateNewListController createNewListController1;
    }
}