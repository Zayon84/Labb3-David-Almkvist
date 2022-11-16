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
    public partial class CreateNewListController : UserControl
    {
        public MainForm Parentform { get; set; }
        public int NrOfLanguages { get; set; }
        public TextBox[] myTextbox = new TextBox[10];               // TODO: fix to a string array instead?

        public CreateNewListController()
        {
            InitializeComponent();
            NrOfLanguages = 2;
            SetTheTextBoxes();
        }

        private void numericUpDownLanguages_ValueChanged(object sender, EventArgs e)
        {
            NrOfLanguages = (int)numericUpDownLanguages.Value;
            SetTheTextBoxes();
        }

        void SetTheTextBoxes()
        {
            try
            {
                int pointX = 10;
                int pointY = 0;
                panelListLanguages.Controls.Clear();

                for (int i = 0; i < NrOfLanguages; i++)
                {
                    TextBox newTextbox = new TextBox();
                    newTextbox.Location = new Point(pointX, pointY);
                    newTextbox.Name = "newTextbox" + i.ToString();

                    myTextbox[i] = newTextbox;
                    panelListLanguages.Controls.Add(newTextbox);
                    panelListLanguages.Show();
                    pointY += 20;
                }
            }
            catch (Exception e) {   MessageBox.Show(e.ToString());  }
        }

        void CreatTheList()
        {
            if (!CheckValidWordListName())
                return;
            if (!CheckValidLanguages())
                return;

            string[] languageString = new string[NrOfLanguages];
            for (int i = 0; i < NrOfLanguages; i++)
            {
                languageString[i] += myTextbox[i].Text + " ";
            }

            WordList newWordList = new WordList(textBoxName.Text, languageString.ToArray());
            newWordList.Save();

            Parentform.RunAddWord(newWordList);
        }

        bool CheckValidWordListName()
        {
            return string.IsNullOrWhiteSpace(textBoxName.Text) ? false : true;
        }

        bool CheckValidLanguages()
        {
            for (int i = 0; i < NrOfLanguages; i++)
            {
                if (string.IsNullOrWhiteSpace(myTextbox[i].Text))
                {
                    return false;
                }
            }
            return true;
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            CreatTheList();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Parentform.RunList();
        }

        private void CreateNewListController_VisibleChanged(object sender, EventArgs e)
        {
            ResetValues();
        }

        void ResetValues()
        {
            textBoxName.Text = "";
            NrOfLanguages = 2;
            numericUpDownLanguages.Value = 2;
            SetTheTextBoxes();
        }
    }
}
