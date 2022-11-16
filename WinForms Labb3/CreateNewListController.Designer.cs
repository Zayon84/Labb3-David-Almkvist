namespace WinForms_Labb3
{
    partial class CreateNewListController
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
            this.buttonCreate = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelEnterName = new System.Windows.Forms.Label();
            this.labelNrOfLanguages = new System.Windows.Forms.Label();
            this.numericUpDownLanguages = new System.Windows.Forms.NumericUpDown();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panelListLanguages = new System.Windows.Forms.Panel();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelLanguages = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLanguages)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCreate
            // 
            this.buttonCreate.Location = new System.Drawing.Point(426, 214);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(124, 23);
            this.buttonCreate.TabIndex = 1;
            this.buttonCreate.Text = "Create WordList";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(146, 214);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 2;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // labelEnterName
            // 
            this.labelEnterName.AutoSize = true;
            this.labelEnterName.Location = new System.Drawing.Point(47, 63);
            this.labelEnterName.Name = "labelEnterName";
            this.labelEnterName.Size = new System.Drawing.Size(93, 15);
            this.labelEnterName.TabIndex = 3;
            this.labelEnterName.Text = "Enter List Name:";
            // 
            // labelNrOfLanguages
            // 
            this.labelNrOfLanguages.AutoSize = true;
            this.labelNrOfLanguages.Location = new System.Drawing.Point(426, 43);
            this.labelNrOfLanguages.Name = "labelNrOfLanguages";
            this.labelNrOfLanguages.Size = new System.Drawing.Size(127, 15);
            this.labelNrOfLanguages.TabIndex = 4;
            this.labelNrOfLanguages.Text = "Number Of Languages";
            // 
            // numericUpDownLanguages
            // 
            this.numericUpDownLanguages.Location = new System.Drawing.Point(426, 61);
            this.numericUpDownLanguages.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numericUpDownLanguages.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownLanguages.Name = "numericUpDownLanguages";
            this.numericUpDownLanguages.Size = new System.Drawing.Size(36, 23);
            this.numericUpDownLanguages.TabIndex = 5;
            this.numericUpDownLanguages.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownLanguages.ValueChanged += new System.EventHandler(this.numericUpDownLanguages_ValueChanged);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTitle.Location = new System.Drawing.Point(267, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(172, 21);
            this.labelTitle.TabIndex = 6;
            this.labelTitle.Text = "Create A new Word List";
            // 
            // panelListLanguages
            // 
            this.panelListLanguages.Location = new System.Drawing.Point(283, 61);
            this.panelListLanguages.Name = "panelListLanguages";
            this.panelListLanguages.Size = new System.Drawing.Size(137, 176);
            this.panelListLanguages.TabIndex = 7;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(146, 60);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(133, 23);
            this.textBoxName.TabIndex = 8;
            // 
            // labelLanguages
            // 
            this.labelLanguages.AutoSize = true;
            this.labelLanguages.Location = new System.Drawing.Point(318, 43);
            this.labelLanguages.Name = "labelLanguages";
            this.labelLanguages.Size = new System.Drawing.Size(64, 15);
            this.labelLanguages.TabIndex = 9;
            this.labelLanguages.Text = "Languages";
            // 
            // CreateNewListController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelLanguages);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.panelListLanguages);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.numericUpDownLanguages);
            this.Controls.Add(this.labelNrOfLanguages);
            this.Controls.Add(this.labelEnterName);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonCreate);
            this.Name = "CreateNewListController";
            this.Size = new System.Drawing.Size(700, 300);
            this.VisibleChanged += new System.EventHandler(this.CreateNewListController_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLanguages)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button buttonCreate;
        private Button buttonCancel;
        private Label labelEnterName;
        private Label labelNrOfLanguages;
        private NumericUpDown numericUpDownLanguages;
        private Label labelTitle;
        private Panel panelListLanguages;
        private TextBox textBoxName;
        private Label labelLanguages;
    }
}
