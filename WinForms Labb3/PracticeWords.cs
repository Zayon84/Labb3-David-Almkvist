﻿using System;
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
    public partial class PracticeWords : UserControl
    {
        public Form1 Parentform { get; set; }

        public PracticeWords()
        {
            InitializeComponent();
        }

        private void button_Main_Click(object sender, EventArgs e)
        {
            Parentform?.RunList();
        }
    }
}
