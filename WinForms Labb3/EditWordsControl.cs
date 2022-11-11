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
    public partial class EditWordsControl : UserControl
    {
        public MainForm Parentform { get; set; }

        public EditWordsControl()
        {
            InitializeComponent();
        }

        public void AddDataGridView()
        {
            dataGridView1.DataSource = null;
            using (DataTable dataTable = new DataTable("Categories"))
            {
                foreach (string item in Parentform?.CurrentList.Languages)
                {
                    DataColumn coloumIndex = new DataColumn(item, typeof(string));
                    dataTable.Columns.Add(coloumIndex);
                }
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.DataSource = dataTable;

                WordList? currentWordList = Parentform?.CurrentList;
                if (currentWordList.Count() != 0)
                {
                    currentWordList.List(0, GetTranslations);

                }

                void GetTranslations(string[] translations)
                {
                    int currentColoums = currentWordList.Languages.Length;

                    string[] test = new string[currentColoums];
                    int currentIndex = 0;
                    foreach (string currentWord in translations)
                    {
                        test[currentIndex] = currentWord;
                        currentIndex++;
                    }
                    dataTable.Rows.Add(test );
                }
            }
        }

        private void FinishEditingButton_Click(object sender, EventArgs e)
        {
            Parentform?.RunList();
        }

        private void EditWordsControl_VisibleChanged(object sender, EventArgs e)
        {
            labelTitle.Text = "Edit the List: " + Parentform?.CurrentList.Name;
        }

        private void EditWordsControl_Load(object sender, EventArgs e)
        {
            AddDataGridView();

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {

        }
    }
}
