using System.Windows.Forms;
using System.Xml.Linq;
using Word_Library;

namespace WinForms_Labb3
{
    public partial class Form1 : Form
    {
        public string[] Mylists { get { return WordList.GetLists(); } }

        public Form1()
        {
            InitializeComponent();
            LoadInStart();
        }

        private void LoadInStart()
        {
            UpdateLists();

            UpdateLanguages(WordList.LoadList(Mylists[0]));

        }

        //private static string[] GetLists()
        //{
        //    string[] mylists = WordList.GetLists();
        //    return mylists;
        //}

        private void UpdateLists()
        {
            foreach (String name in Mylists)
            {
                listBoxWordlist.Items.Add(name);
            }
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
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateLanguages(WordList.LoadList(listBoxWordlist.SelectedItem.ToString()));
            //UpdateLanguages();
            //int listIndex = ;

            //UpdateLanguages(listBoxWordlist.SelectedItems);

            //listBox1.SelectedItems
            //listBoxLanguages.Items.Clear();
            //listBoxLanguages.Items.Add(listBoxWordlist.SelectedItem.ToString());
        }
    }
}