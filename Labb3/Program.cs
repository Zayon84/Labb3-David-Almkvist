﻿// C# Labb3 – Utveckla en applikation för att träna glosor. 
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
TEST_Args_Stuff(true);
LoadInDefaultList();            /// TESTING Functions   // TODO: Remove when done

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
    Console.WriteLine($"_CHECK_ Our args[0] is : {input}");

    (input switch
    {
        "-lists"    => (Action) RunLists,
        "-new"      => RunNew,
        "-remove"   => RunRemove,
        "-words"    => RunWords,
        "-count"    => RunCount,
        "-practice" => RunPractice,
        _           => RunWTF
    })();
}

void RunLists() 
{
    Console.WriteLine($"Input found: -lists = {args[0]}");
    // Listar namnen på alla ordlistor från mappen i appdata/local/”mapp med .dat filer”
    Console.WriteLine($" == List availeble are :");
    int indexCount = 0;
    foreach (String name in WordList.GetLists())
    {
        indexCount++;
        Console.WriteLine($"{indexCount}. {name}");
    }
};
void RunNew()
{
    Console.WriteLine($"Input found: -new = {args[0]}");
    //-new < list name > < language 1 > < language 2 > .. < langauge n >
    //Skapar(och sparar) en ny lista med angivet namn och så många språk som
    //angivits.Går direkt in i loopen för att addera nya ord(se - add).

    //string parameterString =
    //WordList newList = new WordList();


    //WordList myWordList = new WordList("EngSweSpa", "English", "Swedish", "Spanish");

};
void RunAdd()
{
    Console.WriteLine($"Input found: -add = {args[0]}");
    // -add <list name> 
    //Frågar användaren efter ett nytt ord(på listans första språk), och frågar därefter i
    //tur och ordning efter översättningar till alla språk i listan. Sedan fortsätter den att
    //fråga efter nya ord tills användaren avbryter genom att mata in en tom rad.

}
void RunRemove()
{
    Console.WriteLine($"Input found: -remove = {args[0]}");
    //-remove <list name> <language> <word 1> <word 2> .. <word n> 
    //Raderar angivna ord från namngiven lista och språk. 


}
void RunWords()
{
    Console.WriteLine($"Input found: -words = {args[0]}");
    // -words <listname> <sortByLanguage> 
    //Listar ord(alla språk) från angiven lista.Om man anger språk sorteras listan efter
    //det, annars sortera efter första språket. 


}
void RunCount()
{
    Console.WriteLine($"_CHECK_ Input found: -count = {args[0]}");
    // -count <listname> 
    // Skriver ut hur många ord det finns i namngiven lista. 

    string currentListName = args[1];
    WordList currentWordList = WordList.LoadList(currentListName);

    Console.WriteLine($" == -count == The list \"{currentWordList.Name}\" has {currentWordList.Count()} words");
}
void RunPractice()
{
    Console.WriteLine($"Input found: -practice = {args[0]}");
    //-practice < listname >
    //Ber användaren översätta ett slumpvis valt ord ur listan från ett slumpvis valt
    //språk till ett annat. Skriver ut om det var rätt eller fel, och fortsätter fråga efter
    //ord tills användaren lämnar en tom inmatning. Då skrivs antal övade ord ut, samt
    //hur stor andel av orden man haft rätt på.


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
