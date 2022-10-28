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

// Variables for Test Of WordList
WordList myWordList = new WordList("EngSweSpa", "English", "Swedish", "Spanish");
WordList testLoadList = WordList.LoadList("lang3");
TestOfWordList(false);
TEST_Args_Stuff(false);
LoadInDefaultList();            /// TESTING Functions   // TODO: Remove when done

// THE CONSOLE 
//BasePrint();
CheckArguments();
Console.WriteLine();

void TEST_Args_Stuff(bool testingArgs)
{
    if (testingArgs)
    {
        Console.WriteLine("\n_CHECK_ Testing Args stuff!");
        Console.WriteLine($"We have {args.Length} args at this point");
        for (int i = 0; i < args.Length; i++)
        {
            Console.WriteLine($"Args nr{i} is = {args[i]}");
        }

        Console.WriteLine();
    }

}


void CheckArguments()
{
    if (args.Length == 0)
    {
        BasePrint();
        return;
    }

    string input = args[0].ToLower();
    //Console.WriteLine($"_CHECK_ Our args[0] is : {input}");

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
    // Listar namnen på alla ordlistor från mappen i appdata/local/”mapp med .dat filer”
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
    if (args.Length == 1)
    {
        Console.WriteLine("Error! Need a list if we want to add something!");
        return ;
    }
    if (CheckIfListExist(args[1]))
    {
        string currentListName = args[1];
        WordList currentWordList = WordList.LoadList(currentListName);

        AddNewWord(currentWordList);
    }
    else
    {
        Console.WriteLine($"Error! Your list \"{args[1]}\" does´t not exist! ");
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

    //-remove <list name> <language> <word 1> <word 2> .. <word n> 
    //Raderar angivna ord från namngiven lista och språk. 

    if (args.Length == 1)
    {
        Console.WriteLine("Error! Need a list name if we want to remove something!");
        return;
    }
    if (CheckIfListExist(args[1]))
    {
        if (args.Length >3 )
        {
            string currentListName = args[1];
            WordList currentWordList = WordList.LoadList(currentListName);
            Console.WriteLine($"\n == We are trying to removing the word {args[3]}");                       // TODO: need to be able to handle multiple args
            if (currentWordList.Remove(int.Parse(args[2]), args[3]))
            {
                Console.WriteLine("WE FOUND THE WORD!");
                currentWordList.Save();
            }
            else
            {
                Console.WriteLine("WE didn´t find it :(");
            }
        }
        else
        {
            Console.WriteLine($"Error! To remove something from the list \"{args[1]}\" we need both from what language and the word!");
        }
        
    }
    else
    {
        Console.WriteLine("Error! No such list exists");
    }
    

}
void RunWords()
{
    if (args.Length > 1)
    {
        if (CheckIfListExist(args[1]))
        {
            string currentListName = args[1];
            WordList currentWordList = WordList.LoadList(currentListName);
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
        else
        {
            Console.WriteLine("Error! No such list exist");
        }
    }
    else
    {
        Console.WriteLine("Error! No list name entered.");
    }
}

void RunCount()
{
    if (args.Length <= 1)
    {
        Console.WriteLine("A list Name is needed to be counted! ");
    }
    else if (CheckIfListExist(args[1]))
    {
        string currentListName = args[1];
        WordList currentWordList = WordList.LoadList(currentListName);

        Console.WriteLine($"\nThe list \"{currentWordList.Name}\" has {currentWordList.Count()} words");
    }
    else
    {
        Console.WriteLine($"There is no list called \"{args[1]}\" Check your spelling with '-lists'");
    }
}

bool CheckIfListExist(string listname)
{
    foreach (String name in WordList.GetLists())
    {
        if (name == listname)   {   return true;    }
    }
    return false;
}

bool CheckIfListNameWasSent()
{
    if (args.Length <= 1) { return false; }
    return true;
}

void RunPractice()
{
    if (args.Length > 1)
    {
        if (CheckIfListExist(args[1]))
        {
            string currentListName = args[1];
            WordList currentWordList = WordList.LoadList(currentListName);
            bool tryAgain = true;

            float practicedWordsAmount = 0;
            float correctAnswersAmount = 0;

            while (tryAgain)
            {
                practicedWordsAmount++;
                correctAnswersAmount += GuessTheWORD(currentWordList);
                Console.WriteLine("\nTry again? 'y' = yes anything else = no");

                if (Console.ReadLine().ToLower() != "y" )
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
        else
        {
            Console.WriteLine("Error! No such list exists!");
        }
    }
    else
    {
        Console.WriteLine("Error! Need to give a name of List to practice!");
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


void TestOfWordList(bool RunThisTest)
{
    if (RunThisTest)
    {
        // Load in some values to myWordList
        LoadInDefaultList();

        // Test Print out the words in myWordList
        Console.WriteLine(" - Print out myWordList Test");
        myWordList.List(2, PrintTranslations);

        // Test to see whats in the folder
        Console.WriteLine("\n - Getlists name in folder Test:");
        foreach (String name in WordList.GetLists())
        {
            Console.WriteLine(name);
        }

        // Test load in a file to testLoadList and dispaly it
        Console.WriteLine("\n- Load in file Test:");
        testLoadList.List(2, PrintTranslations);

        // Testing Using Save
        Console.WriteLine($"\n - SAVE TEST INFO");
        myWordList.Save();

        // Final Test
        Console.WriteLine($"\n - Get word TEST INFO");
        GuessTheWORDTest();
    }

}

void LoadInDefaultList()
{
    myWordList.Add("Hi", "Hej", "Hola");
    myWordList.Add("World", "Värld", "Mundo");
    myWordList.Add("Car", "Bil", "Coche");
    myWordList.Add("Moon", "Måne", "Luna");
}

void GuessTheWORDTest()
{
    Word wordToPractice = myWordList.GetWordToPractice();

    Console.WriteLine(wordToPractice.Translations[wordToPractice.FromLanguage]);
    Console.WriteLine(wordToPractice.Translations[wordToPractice.ToLanguage]);
    Console.WriteLine("Controll check ...TO NOT READ ABOVE NO CHEATING !!!\n");

    Console.WriteLine($"GUESS THE WORD !  (from{myWordList.Languages[wordToPractice.FromLanguage]} to {myWordList.Languages[wordToPractice.ToLanguage]} )");
    Console.WriteLine($"How do you type {wordToPractice.Translations[wordToPractice.FromLanguage]} in {myWordList.Languages[wordToPractice.ToLanguage]}?");
    string inputString = Console.ReadLine();
    string check = (inputString == wordToPractice.Translations[wordToPractice.ToLanguage]) ? "CORECT" : "WRONG";
    Console.WriteLine($"Your Anser is: {check } !");
}

void PrintTranslations(string[] translations)
{
    foreach (string currentString in translations)
    {
        Console.Write(currentString + " ");
        
    }
    Console.WriteLine();
}
