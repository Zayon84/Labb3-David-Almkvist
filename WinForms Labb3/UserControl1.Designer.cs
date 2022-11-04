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
            this.TEST_LABEL_INFO = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_Practice
            // 
            this.button_Practice.Location = new System.Drawing.Point(548, 186);
            this.button_Practice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_Practice.Name = "button_Practice";
            this.button_Practice.Size = new System.Drawing.Size(122, 47);
            this.button_Practice.TabIndex = 21;
            this.button_Practice.Text = "Practice";
            this.button_Practice.UseVisualStyleBackColor = true;
            this.button_Practice.Click += new System.EventHandler(this.button_Practice_Click);
            // 
            // button_NewList
            // 
            this.button_NewList.Location = new System.Drawing.Point(548, 84);
            this.button_NewList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_NewList.Name = "button_NewList";
            this.button_NewList.Size = new System.Drawing.Size(122, 47);
            this.button_NewList.TabIndex = 20;
            this.button_NewList.Text = "New List";
            this.button_NewList.UseVisualStyleBackColor = true;
            this.button_NewList.Click += new System.EventHandler(this.button_NewList_Click);
            // 
            // button_Edit
            // 
            this.button_Edit.Location = new System.Drawing.Point(548, 135);
            this.button_Edit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_Edit.Name = "button_Edit";
            this.button_Edit.Size = new System.Drawing.Size(122, 47);
            this.button_Edit.TabIndex = 19;
            this.button_Edit.Text = "Edit";
            this.button_Edit.UseVisualStyleBackColor = true;
            this.button_Edit.Click += new System.EventHandler(this.button_Edit_Click);
            // 
            // labelLanguages
            // 
            this.labelLanguages.AutoSize = true;
            this.labelLanguages.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelLanguages.Location = new System.Drawing.Point(288, 67);
            this.labelLanguages.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLanguages.Name = "labelLanguages";
            this.labelLanguages.Size = new System.Drawing.Size(68, 15);
            this.labelLanguages.TabIndex = 18;
            this.labelLanguages.Text = "Languages:";
            // 
            // listBoxLanguages
            // 
            this.listBoxLanguages.FormattingEnabled = true;
            this.listBoxLanguages.ItemHeight = 15;
            this.listBoxLanguages.Location = new System.Drawing.Point(288, 84);
            this.listBoxLanguages.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBoxLanguages.Name = "listBoxLanguages";
            this.listBoxLanguages.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBoxLanguages.Size = new System.Drawing.Size(222, 154);
            this.listBoxLanguages.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(238, 46);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 15);
            this.label2.TabIndex = 16;
            this.label2.Text = "Select a List to use!";
            // 
            // label_WordLists
            // 
            this.label_WordLists.AutoSize = true;
            this.label_WordLists.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_WordLists.Location = new System.Drawing.Point(40, 67);
            this.label_WordLists.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_WordLists.Name = "label_WordLists";
            this.label_WordLists.Size = new System.Drawing.Size(68, 15);
            this.label_WordLists.TabIndex = 15;
            this.label_WordLists.Text = "Word Lists:";
            // 
            // listBoxWordlist
            // 
            this.listBoxWordlist.FormattingEnabled = true;
            this.listBoxWordlist.ItemHeight = 15;
            this.listBoxWordlist.Location = new System.Drawing.Point(40, 84);
            this.listBoxWordlist.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBoxWordlist.Name = "listBoxWordlist";
            this.listBoxWordlist.Size = new System.Drawing.Size(222, 154);
            this.listBoxWordlist.TabIndex = 14;
            this.listBoxWordlist.SelectedIndexChanged += new System.EventHandler(this.listBoxWordlist_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(206, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "Practice Words App";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TEST_LABEL_INFO
            // 
            this.TEST_LABEL_INFO.AutoSize = true;
            this.TEST_LABEL_INFO.Location = new System.Drawing.Point(271, 257);
            this.TEST_LABEL_INFO.Name = "TEST_LABEL_INFO";
            this.TEST_LABEL_INFO.Size = new System.Drawing.Size(38, 15);
            this.TEST_LABEL_INFO.TabIndex = 22;
            this.TEST_LABEL_INFO.Text = "label3";
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TEST_LABEL_INFO);
            this.Controls.Add(this.button_Practice);
            this.Controls.Add(this.button_NewList);
            this.Controls.Add(this.button_Edit);
            this.Controls.Add(this.labelLanguages);
            this.Controls.Add(this.listBoxLanguages);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_WordLists);
            this.Controls.Add(this.listBoxWordlist);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(700, 300);
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
        private Label TEST_LABEL_INFO;
    }
}
