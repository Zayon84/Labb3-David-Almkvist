using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word_Library;

namespace WinForms_Labb3
{
    public partial class CreateNewListForm : Form
    {
        public MainForm Parentform { get; set; }

        public CreateNewListForm()
        {
            InitializeComponent();
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            if (CheckIfValidInputs())
            {
                CreateWordList();
            }
        }

        private bool CheckIfValidInputs()
        {
            if (textBoxListName.Text != "")
            {
                if (textBoxLanguages.Lines.Length > 1)
                {
                    return true;
                }
            }
            return false;
        }

        private void CreateWordList()
        {
            WordList newWordList = new WordList(textBoxListName.Text, textBoxLanguages.Lines.ToArray());
            newWordList.Save();

            Parentform?.RunAddWord(newWordList);

            this.Close();
        }
    }
}
