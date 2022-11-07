using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms_Labb3
{
    public partial class EditWordsControl : UserControl
    {
        public MainForm Parentform { get; set; }

        public EditWordsControl()
        {
            InitializeComponent();
        }

        private void labelTitle_Click(object sender, EventArgs e)
        {

        }

        private void FinishEditingButton_Click(object sender, EventArgs e)
        {
            Parentform?.RunList();
        }

        private void EditWordsControl_VisibleChanged(object sender, EventArgs e)
        {
            labelTitle.Text = "Edit the List: " + Parentform?.CurrentList.Name;
        }
    }
}
