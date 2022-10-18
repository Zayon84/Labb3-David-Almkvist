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

// THE CONSOLE 
BasePrint();
CheckArguments();


void CheckArguments()
{
    string input = args[0];
    input switch
    {
        "-lists" => RunLists(),
        "-new" => RunNew(),
        _ => RunWTF()
    };



    //  Shape myShape;
    //  ShapeForm myShapeForm = (ShapeForm)rand.Next(Enum.GetNames(typeof(ShapeForm)).Length);

    //  myShape = myShapeForm switch
    //  {
    //    ShapeForm.Circle => new Circle(new Vector2(RandomizeFloat(), RandomizeFloat()), RandomizeFloat()),
    //    ShapeForm.Rectangle => new Rectangle(new Vector2(RandomizeFloat(), RandomizeFloat()), new Vector2(RandomizeFloat(), RandomizeFloat()))

    //  };

}

void RunLists() 
{
    Console.WriteLine("Input found: -Lists");
};
void RunNew()
{
    Console.WriteLine("Input found: -new");
};

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
        myWordList.Add("Hi", "Hej", "Hola");
        myWordList.Add("World", "Värld", "Mundo");
        myWordList.Add("Car", "Bil", "Coche");
        myWordList.Add("Moon", "Måne", "Luna");

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
