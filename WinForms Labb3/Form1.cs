using System.Windows.Forms;
using System.Xml.Linq;
using Word_Library;

namespace WinForms_Labb3
{
    public partial class Form1 : Form
    {

        public  bool IsListValid { get; set; }
        public Form1()
        {
            InitializeComponent();

            userControl11.Parentform = this;
           
        }

        //public static void SetValidList(bool isListValid)
        //{
        //    CheckListIfValid(isListValid);

        //}

        public void RunPractice()
        {
            userControl11.Visible = false;
            practiceWords1.Visible = true;
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

    }

}