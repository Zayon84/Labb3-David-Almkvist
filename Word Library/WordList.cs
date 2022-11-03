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
            string path = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            string fullPath = Path.Combine(path, "Labb3");

            if (!Directory.Exists(fullPath))
            {
                DirectoryInfo myDirectory = Directory.CreateDirectory(fullPath);
            }

            string[] files = Directory.GetFiles(fullPath, "*.dat");

            string[] lists = files.Select(file => Path.GetFileNameWithoutExtension(file)).ToArray();
            return lists;
        }

        public static WordList LoadList(string name)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            string fullPath = Path.Combine(path, "Labb3",name + ".dat");

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
            string path = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            string fullPath = Path.Combine(path, "Labb3", this.Name + ".dat");


            if (!Directory.Exists(Path.Combine(path, "Labb3")))
            {
                DirectoryInfo myDirectory = Directory.CreateDirectory(Path.Combine(path, "Labb3"));
            }
            

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
            if (translations.Count() != Languages.Count())
            {
                throw new ArgumentException("Number of translations does not match number of Languages");
            }

            myWordsList.Add(new Word(translations));
        }

        public bool Remove(int translation, string word)
        {
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
            return myWordsList.Count;
        }

        public void List(int sortByTranslation, Action<string[]> showTranslations)
        {
            List<Word> sortedList = myWordsList.OrderBy(w => w.Translations[sortByTranslation]).ToList();

            foreach (Word currentWord in sortedList)
            {
                showTranslations.Invoke(currentWord.Translations);
            }
        }

        public Word GetWordToPractice()
        {
            Random rand = new Random();
            int choosenWordIndex = rand.Next(0, myWordsList.Count); 

            int toLanguage = rand.Next(Languages.Length);
            int fromLanguage = rand.Next(Languages.Length);

            while (toLanguage == fromLanguage)
                {
                    fromLanguage = rand.Next(Languages.Length);
                }

            Word wordToPractice = myWordsList[choosenWordIndex];

            wordToPractice = new Word(fromLanguage,toLanguage,wordToPractice.Translations);

            return wordToPractice;
        }

    }
}
