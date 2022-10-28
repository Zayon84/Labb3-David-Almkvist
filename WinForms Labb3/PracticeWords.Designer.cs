namespace WinForms_Labb3
{
    partial class PracticeWords
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelTitle = new System.Windows.Forms.Label();
            this.button_Main = new System.Windows.Forms.Button();
            this.textBoxInputWord = new System.Windows.Forms.TextBox();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.labelTranslateThis = new System.Windows.Forms.Label();
            this.labelListName = new System.Windows.Forms.Label();
            this.labelResults = new System.Windows.Forms.Label();
            this.labelScore = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTitle.Location = new System.Drawing.Point(441, 45);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(274, 38);
            this.labelTitle.TabIndex = 22;
            this.labelTitle.Text = "Practice Words App";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button_Main
            // 
            this.button_Main.Location = new System.Drawing.Point(68, 86);
            this.button_Main.Name = "button_Main";
            this.button_Main.Size = new System.Drawing.Size(143, 83);
            this.button_Main.TabIndex = 23;
            this.button_Main.Text = "Main";
            this.button_Main.UseVisualStyleBackColor = true;
            this.button_Main.Click += new System.EventHandler(this.button_Main_Click);
            // 
            // textBoxInputWord
            // 
            this.textBoxInputWord.Location = new System.Drawing.Point(406, 304);
            this.textBoxInputWord.Name = "textBoxInputWord";
            this.textBoxInputWord.Size = new System.Drawing.Size(294, 31);
            this.textBoxInputWord.TabIndex = 24;
            this.textBoxInputWord.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxInputWord_KeyDown);
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Location = new System.Drawing.Point(582, 381);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(112, 34);
            this.buttonSubmit.TabIndex = 25;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // labelTranslateThis
            // 
            this.labelTranslateThis.AutoSize = true;
            this.labelTranslateThis.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTranslateThis.Location = new System.Drawing.Point(204, 212);
            this.labelTranslateThis.Name = "labelTranslateThis";
            this.labelTranslateThis.Size = new System.Drawing.Size(734, 38);
            this.labelTranslateThis.TabIndex = 26;
            this.labelTranslateThis.Text = "Translate the language1 word \"thisWord\" to thisLanguage.";
            // 
            // labelListName
            // 
            this.labelListName.AutoSize = true;
            this.labelListName.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelListName.Location = new System.Drawing.Point(639, 176);
            this.labelListName.Name = "labelListName";
            this.labelListName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelListName.Size = new System.Drawing.Size(87, 25);
            this.labelListName.TabIndex = 27;
            this.labelListName.Text = "List name";
            // 
            // labelResults
            // 
            this.labelResults.AutoSize = true;
            this.labelResults.Font = new System.Drawing.Font("Sylfaen", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelResults.Location = new System.Drawing.Point(742, 287);
            this.labelResults.Name = "labelResults";
            this.labelResults.Size = new System.Drawing.Size(0, 52);
            this.labelResults.TabIndex = 28;
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.Location = new System.Drawing.Point(406, 276);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(90, 25);
            this.labelScore.TabIndex = 29;
            this.labelScore.Text = "Score text";
            // 
            // PracticeWords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.labelResults);
            this.Controls.Add(this.labelListName);
            this.Controls.Add(this.labelTranslateThis);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.textBoxInputWord);
            this.Controls.Add(this.button_Main);
            this.Controls.Add(this.labelTitle);
            this.Name = "PracticeWords";
            this.Size = new System.Drawing.Size(1143, 633);
            this.Load += new System.EventHandler(this.PracticeWords_Load);
            this.VisibleChanged += new System.EventHandler(this.PracticeWords_VisibleChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelTitle;
        private Button button_Main;
        private TextBox textBoxInputWord;
        private Button buttonSubmit;
        private Label labelTranslateThis;
        private Label labelListName;
        private Label labelResults;
        private Label labelScore;
    }
}
