// C# Labb3 – Utveckla en applikation för att träna glosor. 
// David Almvkvist - Oct 2022
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Numerics;
using System.Runtime.Intrinsics.X86;
using System.Xml.Linq;
using Word_Library;

Console.WriteLine("\t\tLabb3 – Utveckla en applikation för att träna glosor.\n");

// Variables for Test Of WordList
WordList myWordList = new WordList("EngSweSpa", "English", "Swedish", "Spanish");
WordList testLoadList = WordList.LoadList("lang3");
TestOfWordList(false);
TEST_Args_Stuff(true);

// THE CONSOLE 
BasePrint();
CheckArguments();



void TEST_Args_Stuff(bool testingArgs)
{
    if (true)
    {
        Console.WriteLine("\nTesting Args stuff!");
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
    string input = args[0].ToLower();
    Console.WriteLine($"Our args[0] is : {input}");

    (input switch
    {
        "-lists"    => (Action) RunLists,
        "-new"      => RunNew,
        "-remove"   => RunRemove,
        "-words"    => RunWords,
        "-count"    => RunNew,
        "-practice" => RunNew,
        _           => RunWTF
    })();
}

void RunLists() 
{
    Console.WriteLine($"Input found: -lists = {args[0]}");
};
void RunNew()
{
    Console.WriteLine($"Input found: -new = {args[0]}");
};
void RunAdd()
{
    Console.WriteLine($"Input found: -add = {args[0]}");

}
void RunRemove()
{
    Console.WriteLine($"Input found: -remove = {args[0]}");

}
void RunWords()
{
    Console.WriteLine($"Input found: -words = {args[0]}");

}
void RunCount()
{
    Console.WriteLine($"Input found: -count = {args[0]}");

}
void RunPractice()
{
    Console.WriteLine($"Input found: -practice = {args[0]}");

}

void RunWTF()
{
    Console.WriteLine("What did you want with that ?");
    Console.WriteLine("Input does not match any known command!");
    BasePrint();
}

void BasePrint()
{
    Console.WriteLine("Use any of the following parameters: ");
    Console.WriteLine("\t-lists");
    Console.WriteLine("\t-new < list name > < language 1 > < language 2 > .. < langauge n >");
    Console.WriteLine("\t-add < list name >");
    Console.WriteLine("\t-remove < list name > < language > < word 1 > < word 2 > .. < word n >");
    Console.WriteLine("\t-words<listname> < sortByLanguage >");
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
        testLoadList.List(0, PrintTranslations);

        // Testing Using Save
        Console.WriteLine($"\n - SAVE TEST INFO");
        myWordList.Save();

        // Final Test
        Console.WriteLine($"\n - Get word TEST INFO");
        GuessTheWORD();
    }

}

void LoadInDefaultList()
{
    myWordList.Add("Hi", "Hej", "Hola");
    myWordList.Add("World", "Värld", "Mundo");
    myWordList.Add("Car", "Bil", "Coche");
    myWordList.Add("Moon", "Måne", "Luna");
}

void GuessTheWORD()
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
