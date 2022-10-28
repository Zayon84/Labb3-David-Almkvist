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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNrOfLanguages)).BeginInit();
            this.SuspendLayout();
            // 
            // labelEnterListName
            // 
            this.labelEnterListName.AutoSize = true;
            this.labelEnterListName.Location = new System.Drawing.Point(76, 73);
            this.labelEnterListName.Name = "labelEnterListName";
            this.labelEnterListName.Size = new System.Drawing.Size(139, 25);
            this.labelEnterListName.TabIndex = 0;
            this.labelEnterListName.Text = "Enter List Name:";
            // 
            // textBoxListName
            // 
            this.textBoxListName.Location = new System.Drawing.Point(76, 110);
            this.textBoxListName.Name = "textBoxListName";
            this.textBoxListName.Size = new System.Drawing.Size(150, 31);
            this.textBoxListName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nr of languages";
            // 
            // numericUpDownNrOfLanguages
            // 
            this.numericUpDownNrOfLanguages.Location = new System.Drawing.Point(220, 147);
            this.numericUpDownNrOfLanguages.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownNrOfLanguages.Name = "numericUpDownNrOfLanguages";
            this.numericUpDownNrOfLanguages.Size = new System.Drawing.Size(64, 31);
            this.numericUpDownNrOfLanguages.TabIndex = 3;
            this.numericUpDownNrOfLanguages.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.Location = new System.Drawing.Point(264, 311);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(112, 34);
            this.buttonConfirm.TabIndex = 4;
            this.buttonConfirm.Text = "Confirm";
            this.buttonConfirm.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(12, 311);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(112, 34);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(73, 204);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(150, 46);
            this.textBox1.TabIndex = 6;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(264, 184);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(180, 129);
            this.listBox1.TabIndex = 7;
            // 
            // CreateNewListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 391);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonConfirm);
            this.Controls.Add(this.numericUpDownNrOfLanguages);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxListName);
            this.Controls.Add(this.labelEnterListName);
            this.Name = "CreateNewListForm";
            this.Text = "CreateNewListForm";
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
        private TextBox textBox1;
        private ListBox listBox1;
    }
}