using System.Windows.Forms;
using System.Xml.Linq;
using Word_Library;

namespace WinForms_Labb3
{
    public partial class MainForm : Form
    {

        public  bool IsListValid { get; set; }
        public WordList CurrentList { get; set; }

        public MainForm()
        {
            InitializeComponent();

            userControl11.Parentform = this;
            practiceWords1.Parentform = this;
            editWordsControl1.Parentform = this;
            
           
        }

        public void SetCurrentList(WordList myList)
        {
            CurrentList = myList;
        }

        public void RunNew()
        {
            CreateNewListForm newForm = new();
            DialogResult result = newForm.ShowDialog();
        }
        public void RunList()
        {
            userControl11.Visible = true;
            practiceWords1.Visible = false;
            editWordsControl1.Visible = false;

        }

        public void RunPractice()
        {
            userControl11.Visible = false;
            practiceWords1.Visible = true;
            editWordsControl1.Visible = false;
        }

        public void RunAddWord()
        {
            userControl11.Visible = false;
            practiceWords1.Visible = false;
            editWordsControl1.Visible = true;
            editWordsControl1.AddColoums();
        }

        public void RunAddWord(WordList currentList)
        {
            CurrentList = currentList;
            RunAddWord();
        }

        public  void CheckListIfValid(bool isValidList)
        {
            practiceToolStripMenuItem.Enabled = isValidList;
            EditToolStripMenuItem.Enabled = isValidList;
            countToolStripMenuItem.Enabled = isValidList;
            wordsToolStripMenuItem.Enabled = isValidList;
            listsToolStripMenuItem.Enabled = isValidList;
        }

        public void SetPracticeMenu(bool hasWords)
        {
            practiceToolStripMenuItem.Enabled = hasWords;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.panelStart.Controls.Add(this.practiceWords1);
            this.panelStart.Controls.Add(this.userControl11);
        }

        private void listsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RunList();
        }

        private void practiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RunPractice();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RunNew();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RunAddWord();
        }
    }

}