using System.Windows.Forms;
using System.Xml.Linq;
using Word_Library;

namespace WinForms_Labb3
{
    public partial class Form1 : Form
    {

        public  bool IsListValid { get; set; }
        public WordList CurrentList { get; set; }
        public Form1()
        {
            InitializeComponent();

            userControl11.Parentform = this;
            practiceWords1.Parentform = this;
            
           
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

        }

        public void RunPractice()
        {
            userControl11.Visible = false;
            practiceWords1.Visible = true;

        }

        public void RunAddWord()
        {

        }

        public  void CheckListIfValid(bool isValidList)
        {

            //bool isValidList = true;

            practiceToolStripMenuItem.Enabled = isValidList;
            addToolStripMenuItem.Enabled = isValidList;
            countToolStripMenuItem.Enabled = isValidList;
            wordsToolStripMenuItem.Enabled = isValidList;
            listsToolStripMenuItem.Enabled = isValidList;
            removeToolStripMenuItem.Enabled = isValidList;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.panelStart.Controls.Add(this.practiceWords1);
            this.panelStart.Controls.Add(this.userControl11);
        }

        private void practiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RunPractice();
        }
    }

}