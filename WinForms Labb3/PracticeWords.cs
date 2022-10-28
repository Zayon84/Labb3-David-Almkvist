using System;
using System.Collections;
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
    public partial class PracticeWords : UserControl
    {
        public Form1 Parentform { get; set; }

        public WordList CurrentWordList { get { return Parentform?.CurrentList; } }
        public Word WordToPractice { get; set; }

        public int NrOfTries { get; set; }
        public int NrOfCorrectsAnswers { get; set; }


        public PracticeWords()
        {
            InitializeComponent();
            ResetScore();
        }

        void ResetScore()
        {
            NrOfCorrectsAnswers = 0;
            NrOfTries = 0;
            labelScore.Text = "";
        }

        private void SetCurrentList()
        {
            //labelListName.Text = Parentform?.CurrentList.Name;
            //labelCount.Text = $"With {Parentform?.CurrentList.Count()} Words to practice. ";

            //WordList currentWordList = Parentform?.CurrentList;
            //Word wordToPractice = null;

            GetNewWord();
        }

        private void GetNewWord()
        {
            if (CurrentWordList != null)
            {
                string listNameInfo = $"{CurrentWordList.Name} With {CurrentWordList.Count()} Words to practice.";
                labelListName.Text = listNameInfo;


                WordToPractice = CurrentWordList.GetWordToPractice();


                labelTranslateThis.Text = $"Translate the {CurrentWordList.Languages[WordToPractice.FromLanguage]} " +
                    $"word \"{WordToPractice.Translations[WordToPractice.FromLanguage]}\" " +
                    $"to {CurrentWordList.Languages[WordToPractice.ToLanguage]}.";
                //

            }
        }

        bool CompareWord()
        {
            return (textBoxInputWord.Text.ToLower() == WordToPractice.Translations[WordToPractice.ToLanguage].ToLower()) ? true : false;
        }

        void GetWords()
        {
            //gussWordsList = Parentform?.CurrentList;
        }
        private void button_Main_Click(object sender, EventArgs e)
        {
            Parentform?.RunList();
        }

        private void PracticeWords_Load(object sender, EventArgs e)
        {
            SetCurrentList();

        }

        private void PracticeWords_VisibleChanged(object sender, EventArgs e)
        {
            UpdateScreen();
            ResetScore();
        }

        private void UpdateScreen()
        {
            SetCurrentList();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            CheckSubmit();
        }

        void CheckSubmit()
        {
            if (CompareWord())
            {
                labelResults.ForeColor = Color.Green;
                labelResults.Text = "Correct!";
                NrOfCorrectsAnswers++;
            }
            else
            {
                labelResults.ForeColor = Color.Red;
                labelResults.Text = "Wrong!";
            }

            NrOfTries++;
            UpdateScore();
            textBoxInputWord.Text = "";
            Task.Delay(2000).Wait();
            labelResults.Text = "";

            GetNewWord();
        }

        void UpdateScore()
        {
            labelScore.Text = $"You have answerd {NrOfCorrectsAnswers}/{NrOfTries} words Correct!";
        }

        private void textBoxInputWord_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CheckSubmit();
            }
        }

    }
}
