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
    public partial class UserControl1 : UserControl
    {
        
        public MainForm Parentform { get; set; }
        public string[] Mylists { get { return WordList.GetLists(); } }

        public UserControl1()
        {
            InitializeComponent();

        }

        private void LoadInStart()
        {
            if (CheckForValidList())
            {
                UpdateLists();

                UpdateLanguages(WordList.LoadList(Mylists[0]));
            }
        }

        private bool CheckForValidList()
        {
            if (Mylists.Length == 0)
            {
                listBoxWordlist.Items.Add(" - No list found -");
                listBoxLanguages.Items.Add(" - No language found -");

                Parentform?.CheckListIfValid(false);

                button_Edit.Enabled = false;
                button_Practice.Enabled = false;
                return false;
            }
            return true;
        }

        private void UpdateLists()
        {
            listBoxWordlist.Items.Clear();
            foreach (String name in Mylists)
            {
                listBoxWordlist.Items.Add(name);
            }
            //if (listBoxWordlist.SelectedIndex == null)
            //{
            //}
            listBoxWordlist.SelectedIndex = 0;

        }
        private void UpdateLanguages(WordList mylist)
        {
            listBoxLanguages.Items.Clear();
            WordList currentWordList = mylist;
            foreach (var language in currentWordList.Languages)
            {
                listBoxLanguages.Items.Add(language);
            }
        }
        private void listBoxWordlist_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Mylists.Length != 0)
            {
                Parentform.CurrentList = (WordList.LoadList(listBoxWordlist.SelectedItem.ToString()));

                DisablePracticeIfNoWords();

                UpdateLanguages(WordList.LoadList(listBoxWordlist.SelectedItem.ToString()));
            }
        }

        private void DisablePracticeIfNoWords()
        {
            bool showPracticeButtons = Parentform.CurrentList.Count() == 0 ? false : true;
            button_Practice.Enabled = showPracticeButtons;
            Parentform.SetPracticeMenu(showPracticeButtons);
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            LoadInStart();

        }

        private void button_Practice_Click(object sender, EventArgs e)
        {
            Parentform?.RunPractice();
        }

        private void button_NewList_Click(object sender, EventArgs e)
        {
            Parentform?.RunNew();

        }

        private void button_Edit_Click(object sender, EventArgs e)
        {
            Parentform?.RunAddWord();
        }
    }
}
