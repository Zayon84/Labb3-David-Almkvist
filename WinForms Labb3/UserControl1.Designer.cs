namespace WinForms_Labb3
{
    partial class UserControl1
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
            this.button_Practice = new System.Windows.Forms.Button();
            this.button_NewList = new System.Windows.Forms.Button();
            this.button_Edit = new System.Windows.Forms.Button();
            this.labelLanguages = new System.Windows.Forms.Label();
            this.listBoxLanguages = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label_WordLists = new System.Windows.Forms.Label();
            this.listBoxWordlist = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_Practice
            // 
            this.button_Practice.Location = new System.Drawing.Point(783, 310);
            this.button_Practice.Name = "button_Practice";
            this.button_Practice.Size = new System.Drawing.Size(175, 79);
            this.button_Practice.TabIndex = 21;
            this.button_Practice.Text = "Practice";
            this.button_Practice.UseVisualStyleBackColor = true;
            this.button_Practice.Click += new System.EventHandler(this.button_Practice_Click);
            // 
            // button_NewList
            // 
            this.button_NewList.Location = new System.Drawing.Point(783, 140);
            this.button_NewList.Name = "button_NewList";
            this.button_NewList.Size = new System.Drawing.Size(175, 79);
            this.button_NewList.TabIndex = 20;
            this.button_NewList.Text = "New List";
            this.button_NewList.UseVisualStyleBackColor = true;
            this.button_NewList.Click += new System.EventHandler(this.button_NewList_Click);
            // 
            // button_Edit
            // 
            this.button_Edit.Location = new System.Drawing.Point(783, 225);
            this.button_Edit.Name = "button_Edit";
            this.button_Edit.Size = new System.Drawing.Size(175, 79);
            this.button_Edit.TabIndex = 19;
            this.button_Edit.Text = "Edit";
            this.button_Edit.UseVisualStyleBackColor = true;
            this.button_Edit.Click += new System.EventHandler(this.button_Edit_Click);
            // 
            // labelLanguages
            // 
            this.labelLanguages.AutoSize = true;
            this.labelLanguages.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelLanguages.Location = new System.Drawing.Point(411, 112);
            this.labelLanguages.Name = "labelLanguages";
            this.labelLanguages.Size = new System.Drawing.Size(108, 25);
            this.labelLanguages.TabIndex = 18;
            this.labelLanguages.Text = "Languages:";
            this.labelLanguages.Click += new System.EventHandler(this.labelLanguages_Click);
            // 
            // listBoxLanguages
            // 
            this.listBoxLanguages.FormattingEnabled = true;
            this.listBoxLanguages.ItemHeight = 25;
            this.listBoxLanguages.Location = new System.Drawing.Point(411, 140);
            this.listBoxLanguages.Name = "listBoxLanguages";
            this.listBoxLanguages.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBoxLanguages.Size = new System.Drawing.Size(315, 254);
            this.listBoxLanguages.TabIndex = 17;
            this.listBoxLanguages.SelectedIndexChanged += new System.EventHandler(this.listBoxLanguages_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(340, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 25);
            this.label2.TabIndex = 16;
            this.label2.Text = "Select a List to use!";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label_WordLists
            // 
            this.label_WordLists.AutoSize = true;
            this.label_WordLists.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_WordLists.Location = new System.Drawing.Point(57, 112);
            this.label_WordLists.Name = "label_WordLists";
            this.label_WordLists.Size = new System.Drawing.Size(106, 25);
            this.label_WordLists.TabIndex = 15;
            this.label_WordLists.Text = "Word Lists:";
            this.label_WordLists.Click += new System.EventHandler(this.label_WordLists_Click);
            // 
            // listBoxWordlist
            // 
            this.listBoxWordlist.FormattingEnabled = true;
            this.listBoxWordlist.ItemHeight = 25;
            this.listBoxWordlist.Location = new System.Drawing.Point(57, 140);
            this.listBoxWordlist.Name = "listBoxWordlist";
            this.listBoxWordlist.Size = new System.Drawing.Size(315, 254);
            this.listBoxWordlist.TabIndex = 14;
            this.listBoxWordlist.SelectedIndexChanged += new System.EventHandler(this.listBoxWordlist_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(294, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 38);
            this.label1.TabIndex = 13;
            this.label1.Text = "Practice Words App";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button_Practice);
            this.Controls.Add(this.button_NewList);
            this.Controls.Add(this.button_Edit);
            this.Controls.Add(this.labelLanguages);
            this.Controls.Add(this.listBoxLanguages);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_WordLists);
            this.Controls.Add(this.listBoxWordlist);
            this.Controls.Add(this.label1);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(1028, 633);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button_Practice;
        private Button button_NewList;
        private Button button_Edit;
        private Label labelLanguages;
        private ListBox listBoxLanguages;
        private Label label2;
        private Label label_WordLists;
        private ListBox listBoxWordlist;
        private Label label1;
    }
}
