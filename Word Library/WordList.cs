﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Xml.Linq;

namespace Word_Library
{
    public class WordList
    {
        private List<Word> myWordsList = new List<Word>();

        public WordList(string name, params string[] languages)
        {
            this.Name = name;
            this.Languages = languages;
        }

        public string Name { get; }

        public string[] Languages { get; }

        public static string[] GetLists()
        {
            //Returnerar array med namn på alla listor som finns lagrade(utan filändelsen). 
            string path = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            string fullPath = Path.Combine(path, "Labb3");
            string[] files = Directory.GetFiles(fullPath, "*.dat");

            string[] lists = files.Select(file => Path.GetFileNameWithoutExtension(file)).ToArray();
            return lists;
        }

        public static WordList LoadList(string name)
        {
            // Laddar in ordlistan(name anges utan filändelse) och returnerar som WordList.
            return null;
        }

        public void Save()
        {
            // Sparar listan till en fil med samma namn som listan och filändelse.dat
        }

        public void Add(params string[] translations)
        {
            //Lägger till ord i listan.Kasta ArgumentException om det är fel antal translations.
            if (translations.Count() != Languages.Count())
            {
                throw new ArgumentException("Number of translations does not match number of Languages");
            }

            myWordsList.Add(new Word(translations));
        }
        public bool Remove(int translation, string word)
        {
            //translation motsvarar index i Languages.Sök igenom språket och ta bort ordet.
            //Returnerar true om ordet fanns(och alltså tagits bort), annars false.
            foreach (Word currentWord in myWordsList)
            {
                if (currentWord.Translations[translation] == word)
                {
                    myWordsList.Remove(currentWord);
                    return true;
                }
            }
            return false;
        }

        public int Count()
        {
            //Räknar och returnerar antal ord i listan.
            return myWordsList.Count;
        }

        public void List(int sortByTranslation, Action<string[]> showTranslations)
        {
            //sortByTranslation = Vilket språk listan ska sorteras på.
            //showTranslations = Callback som anropas för varje ord i listan.
        }

        public Word GetWordToPractice()
        {
            //Returnerar slumpmässigt Word från listan, med slumpmässigt valda
            //FromLanguage och ToLanguage(dock inte samma). 
            return null;
        }

    }
}