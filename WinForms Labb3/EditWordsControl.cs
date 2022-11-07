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

        void AddColoums()
        {
            using (DataTable dataTable = new DataTable("Categories"))
            {
                foreach (string item in Parentform?.CurrentList.Languages)
                {
                    DataColumn coloumIndex = new DataColumn(item, typeof(string));
                    dataTable.Columns.Add(coloumIndex);
                }
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.DataSource = dataTable;

                if (Parentform?.CurrentList.Count() != 0)
                {
                    // TODO: add words in
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
            AddColoums();

        }
    }
}
