namespace WinForms_Labb3
{
    partial class CreateNewListForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelEnterListName = new System.Windows.Forms.Label();
            this.textBoxListName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownNrOfLanguages = new System.Windows.Forms.NumericUpDown();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.textBoxLanguages = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNrOfLanguages)).BeginInit();
            this.SuspendLayout();
            // 
            // labelEnterListName
            // 
            this.labelEnterListName.AutoSize = true;
            this.labelEnterListName.Location = new System.Drawing.Point(91, 21);
            this.labelEnterListName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEnterListName.Name = "labelEnterListName";
            this.labelEnterListName.Size = new System.Drawing.Size(93, 15);
            this.labelEnterListName.TabIndex = 0;
            this.labelEnterListName.Text = "Enter List Name:";
            // 
            // textBoxListName
            // 
            this.textBoxListName.Location = new System.Drawing.Point(91, 43);
            this.textBoxListName.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxListName.Name = "textBoxListName";
            this.textBoxListName.Size = new System.Drawing.Size(106, 23);
            this.textBoxListName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 84);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nr of languages";
            // 
            // numericUpDownNrOfLanguages
            // 
            this.numericUpDownNrOfLanguages.Location = new System.Drawing.Point(42, 107);
            this.numericUpDownNrOfLanguages.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDownNrOfLanguages.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownNrOfLanguages.Name = "numericUpDownNrOfLanguages";
            this.numericUpDownNrOfLanguages.Size = new System.Drawing.Size(45, 23);
            this.numericUpDownNrOfLanguages.TabIndex = 3;
            this.numericUpDownNrOfLanguages.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.Location = new System.Drawing.Point(218, 258);
            this.buttonConfirm.Margin = new System.Windows.Forms.Padding(2);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(78, 20);
            this.buttonConfirm.TabIndex = 4;
            this.buttonConfirm.Text = "Confirm";
            this.buttonConfirm.UseVisualStyleBackColor = true;
            this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirm_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(11, 258);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(78, 20);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // textBoxLanguages
            // 
            this.textBoxLanguages.Location = new System.Drawing.Point(91, 101);
            this.textBoxLanguages.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxLanguages.Multiline = true;
            this.textBoxLanguages.Name = "textBoxLanguages";
            this.textBoxLanguages.Size = new System.Drawing.Size(93, 29);
            this.textBoxLanguages.TabIndex = 6;
            // 
            // CreateNewListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 302);
            this.Controls.Add(this.textBoxLanguages);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonConfirm);
            this.Controls.Add(this.numericUpDownNrOfLanguages);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxListName);
            this.Controls.Add(this.labelEnterListName);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CreateNewListForm";
            this.Text = "Create New List";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNrOfLanguages)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelEnterListName;
        private TextBox textBoxListName;
        private Label label1;
        private NumericUpDown numericUpDownNrOfLanguages;
        private Button buttonConfirm;
        private Button buttonCancel;
        private TextBox textBoxLanguages;
    }
}