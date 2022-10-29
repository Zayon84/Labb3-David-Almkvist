// C# Labb3 – Utveckla en applikation för att träna glosor. 
// David Almvkvist - Oct 2022
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Numerics;
using System.Reflection.Metadata;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;
using System.Xml.Linq;
using Word_Library;

Console.WriteLine("\t\tLabb3 – Utveckla en applikation för att träna glosor.\n");

CheckArguments();
Console.WriteLine();

void CheckArguments()
{
    if (args.Length == 0)
    {
        BasePrint();
        return;
    }

    string input = args[0].ToLower();

    (input switch
    {
        "-lists"    => (Action) RunLists,
        "-new"      => RunNew,
        "-add"      => RunAdd,
        "-remove"   => RunRemove,
        "-words"    => RunWords,
        "-count"    => RunCount,
        "-practice" => RunPractice,
        _           => RunWTF
    })();
}

void RunLists() 
{
    Console.WriteLine($" == Available List are:");
    int indexCount = 0;
    foreach (String name in WordList.GetLists())
    {
        indexCount++;
        Console.WriteLine($"{indexCount}. {name}");
    }
};

void RunNew()
{
    if (args.Length < 4)
    {
        Console.WriteLine(" Error! in creating new list: need a name and at least 2 languages");
        return;
    }

    WordList newList = new WordList(args[1], args.Skip(2).ToArray());
    newList.Save();
    Console.WriteLine($"New list has been created called \"{args[1]}\"");
    RunAdd();
};

void RunAdd()
{
    if (CheckIfListIsValid())
    {
        WordList currentWordList = GetCurrentWordList();

        AddNewWord(currentWordList);
    }
}

void AddNewWord( WordList myList)
{
    int nrOfLanguages = myList.Languages.Length;
    bool isRunning = true;
    while (isRunning)
    {
        Console.WriteLine($"The list \"{myList.Name}\" have {nrOfLanguages} languages:");

        string[] wordsArray = new string[nrOfLanguages]; ;

        for (int i = 0; i < nrOfLanguages; i++)
        {
            if (i == 0) {   Console.Write($"Enter a word in {myList.Languages[i]}: ");  }
            else        {   Console.Write($"Enter a translation in {myList.Languages[i]}: ");  }

            string currentInput = Console.ReadLine();
            if (currentInput == "")
            {
                Console.WriteLine("No words found, we are quiting adding words!");
                return;
            }
            wordsArray[i] = currentInput;
        }
        myList.Add(wordsArray);
        myList.Save();
        Console.WriteLine();
    }
}

void RunRemove()
{
    if (CheckIfListIsValid())
    {
        if (args.Length > 3)
        {
            WordList currentWordList = GetCurrentWordList();
            Console.WriteLine("aisdaiofasf " + currentWordList.Languages.Length);
            if ((int.Parse(args[2]) >= 0) && (int.Parse(args[2]) < currentWordList.Languages.Length) )
            {
                for (int i = 3; i < args.Length; i++)
                {
                    Console.WriteLine($"\n == We are trying to removing the word {args[i]}");
                    if (currentWordList.Remove(int.Parse(args[2]), args[i]))
                    {
                        Console.WriteLine("WE FOUND THE WORD!");
                        currentWordList.Save();
                    }
                    else
                    {
                        Console.WriteLine("WE didn´t find it :(");
                    }
                }
            }
            else
            {
                Console.WriteLine("Error! The language we try to serch for is not within range!");
            }
            
        }
        else
        {
            Console.WriteLine($"Error! To remove something from the list \"{args[1]}\" we need both from what language and the word!");
        }
    }
}

void RunWords()
{
    if (CheckIfListIsValid())
    {
        WordList currentWordList = GetCurrentWordList();
        if (currentWordList.Count() == 0)
        {
            Console.WriteLine($"There are no words in the list \"{currentWordList.Name}\"");
            return;
        }

        int sortLanguageFrom = 0;
        if (args.Length > 2)
        {
            sortLanguageFrom = currentWordList.Languages.Length > int.Parse(args[2]) ? int.Parse(args[2]) : 0;
        }
        Console.WriteLine($"\nThe List \"{args[1]}\" has {currentWordList.Count()} word and is listed from {currentWordList.Languages[sortLanguageFrom]}:");
        currentWordList.List(sortLanguageFrom, PrintTranslations);
    }
}

void RunCount()
{
    if (CheckIfListIsValid())
    {
        WordList currentWordList = GetCurrentWordList();

        Console.WriteLine($"\nThe list \"{currentWordList.Name}\" has {currentWordList.Count()} words");
    }
}

void RunPractice()
{
    if (CheckIfListIsValid())
    {
        WordList currentWordList = GetCurrentWordList();
        bool tryAgain = true;

        float practicedWordsAmount = 0;
        float correctAnswersAmount = 0;

        while (tryAgain)
        {
            practicedWordsAmount++;
            correctAnswersAmount += GuessTheWORD(currentWordList);
            Console.WriteLine("\nTry again? 'y' = yes anything else = no");

            if (Console.ReadLine().ToLower() != "y")
            {
                tryAgain = false;
                float winProcent = correctAnswersAmount / practicedWordsAmount * 100;
                Console.WriteLine($"You have practiced {practicedWordsAmount} words and got {correctAnswersAmount} right " +
                    $"thats make it {winProcent:f1}% success rate");
                if (winProcent > 75)
                {
                    Console.WriteLine("Higher then 75%, GOOD JOB!");
                }
                else if (winProcent < 25)
                {
                    Console.WriteLine("ummm You need to practice some more!");
                }
            }
        }
    }
}

int GuessTheWORD(WordList myList)
{
    Word wordToPractice = myList.GetWordToPractice();
    Console.WriteLine($"GUESS THE WORD! (from {myList.Languages[wordToPractice.FromLanguage]} to {myList.Languages[wordToPractice.ToLanguage]} )");
    Console.Write($"How do you type {wordToPractice.Translations[wordToPractice.FromLanguage]} in {myList.Languages[wordToPractice.ToLanguage]}?: ");

    string inputString = Console.ReadLine();
    int score = 0;
    Console.Write($"Your Anser is: ");
    if (inputString.ToLower() == wordToPractice.Translations[wordToPractice.ToLanguage].ToLower())
    {
        score = 1;
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write($"CORECT");
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write($"WRONG");
    }
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("!");

    return score;
}

void RunWTF()
{
    Console.WriteLine("Input does not match any known command!");
    Console.WriteLine();
    BasePrint();
}

void BasePrint()
{
    Console.WriteLine("Use any of the following parameters: ");
    Console.WriteLine("\t-lists");
    Console.WriteLine("\t-new < list name > < language 1 > < language 2 > .. < langauge n >");
    Console.WriteLine("\t-add < list name >");
    Console.WriteLine("\t-remove < list name > < language > < word 1 > < word 2 > .. < word n >");
    Console.WriteLine("\t-words <listname> < sortByLanguage >");
    Console.WriteLine("\t-count < listname >");
    Console.WriteLine("\t-practice<listname>");
}

bool CheckIfListIsValid()
{
    if (args.Length > 1)
    {
        if (CheckIfListExist(args[1]))
        {
            return true;
        }
        else
        {
            Console.WriteLine("Error! invalid List name!");
            return false;
        }
    }
    else
    {
        Console.WriteLine("Error! A \"list name\" is needed to use this command!");
        return false;
    }
}

bool CheckIfListExist(string listname)
{
    foreach (String name in WordList.GetLists())
    {
        if (name.ToLower() == listname.ToLower()) { return true; }
    }
    return false;
}

void PrintTranslations(string[] translations)
{
    foreach (string currentString in translations)
    {
        Console.Write(currentString + " ");
        
    }
    Console.WriteLine();
}

 WordList GetCurrentWordList()
{
    string currentListName = args[1];
    WordList currentWordList = WordList.LoadList(currentListName.ToLower());
    return currentWordList;
}