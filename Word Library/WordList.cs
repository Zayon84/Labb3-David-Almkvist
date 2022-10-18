using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Reflection.PortableExecutable;
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
            //Console.WriteLine(path);
            string fullPath = Path.Combine(path, "Labb3");
            //Console.WriteLine(fullPath);
            string[] files = Directory.GetFiles(fullPath, "*.dat");

            string[] lists = files.Select(file => Path.GetFileNameWithoutExtension(file)).ToArray();
            return lists;
        }

        public static WordList LoadList(string name)
        {
            // Laddar in ordlistan(name anges utan filändelse) och returnerar som WordList.
            string path = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            string fullPath = Path.Combine(path, "Labb3",name + ".dat");
            //Console.WriteLine("File in path " + fullPath);


            using (StreamReader reader = new StreamReader(fullPath))
            {
                string[] languages = reader.ReadLine().Split(";",StringSplitOptions.RemoveEmptyEntries);

                WordList currentList = new WordList(name, languages);

                while (!reader.EndOfStream)
                {
                    string[] words = reader.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries);
                    currentList.Add(words);
                }
                return currentList;
            }
        }

        public void Save()
        {
            // Sparar listan till en fil med samma namn som listan och filändelse.dat
            string path = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            string fullPath = Path.Combine(path, "Labb3", this.Name + ".dat");

            using (StreamWriter writer = new StreamWriter(fullPath))
            {
                writer.WriteLine((String.Join(";", Languages) ));

                foreach (Word currentWord in myWordsList)
                {
                    writer.WriteLine((String.Join(";",currentWord.Translations )));
                }
            }
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
            List<Word> sortedList = myWordsList.OrderBy(w => w.Translations[sortByTranslation]).ToList();

            foreach (Word currentWord in sortedList)
            {
                showTranslations.Invoke(currentWord.Translations);
            }
        }

        public Word GetWordToPractice()
        {
            //Returnerar slumpmässigt Word från listan, med slumpmässigt valda
            //FromLanguage och ToLanguage(dock inte samma). 

            Random rand = new Random();
            int choosenWordIndex = rand.Next(0, myWordsList.Count);                             // TODO: Refacor to proper words

            int toL = rand.Next(Languages.Length);
            int fromL = rand.Next(Languages.Length);

            while (toL == fromL)
                {
                    fromL = rand.Next(Languages.Length);
                }

            Word theChoosenOne = myWordsList[choosenWordIndex];

            theChoosenOne = new Word(fromL,toL,theChoosenOne.Translations);

            return theChoosenOne;
        }

    }
}
