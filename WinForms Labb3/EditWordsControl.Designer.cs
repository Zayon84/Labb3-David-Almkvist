namespace WinForms_Labb3
{
    partial class EditWordsControl
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
            this.FinishEditingButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTitle.Location = new System.Drawing.Point(242, 15);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(203, 25);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Edit the List currentList";
            this.labelTitle.Click += new System.EventHandler(this.labelTitle_Click);
            // 
            // FinishEditingButton
            // 
            this.FinishEditingButton.Location = new System.Drawing.Point(544, 218);
            this.FinishEditingButton.Name = "FinishEditingButton";
            this.FinishEditingButton.Size = new System.Drawing.Size(111, 41);
            this.FinishEditingButton.TabIndex = 1;
            this.FinishEditingButton.Text = "Done Editing";
            this.FinishEditingButton.UseVisualStyleBackColor = true;
            this.FinishEditingButton.Click += new System.EventHandler(this.FinishEditingButton_Click);
            // 
            // EditWordsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.FinishEditingButton);
            this.Controls.Add(this.labelTitle);
            this.Name = "EditWordsControl";
            this.Size = new System.Drawing.Size(700, 300);
            this.VisibleChanged += new System.EventHandler(this.EditWordsControl_VisibleChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelTitle;
        private Button FinishEditingButton;
    }
}
