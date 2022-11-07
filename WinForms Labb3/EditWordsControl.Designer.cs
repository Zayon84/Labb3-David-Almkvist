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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTitle.Location = new System.Drawing.Point(230, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(203, 25);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Edit the List currentList";
            // 
            // FinishEditingButton
            // 
            this.FinishEditingButton.Location = new System.Drawing.Point(544, 238);
            this.FinishEditingButton.Name = "FinishEditingButton";
            this.FinishEditingButton.Size = new System.Drawing.Size(111, 41);
            this.FinishEditingButton.TabIndex = 1;
            this.FinishEditingButton.Text = "Done Editing";
            this.FinishEditingButton.UseVisualStyleBackColor = true;
            this.FinishEditingButton.Click += new System.EventHandler(this.FinishEditingButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(23, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(632, 177);
            this.dataGridView1.TabIndex = 2;
            // 
            // EditWordsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.FinishEditingButton);
            this.Controls.Add(this.labelTitle);
            this.Name = "EditWordsControl";
            this.Size = new System.Drawing.Size(700, 300);
            this.Load += new System.EventHandler(this.EditWordsControl_Load);
            this.VisibleChanged += new System.EventHandler(this.EditWordsControl_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelTitle;
        private Button FinishEditingButton;
        private DataGridView dataGridView1;
    }
}
