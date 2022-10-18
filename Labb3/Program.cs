// C# Labb3 – Utveckla en applikation för att träna glosor. 
// David Almvkvist - Oct 2022
using Word_Library;

Console.WriteLine("\t\tLabb3 – Utveckla en applikation för att träna glosor.\n");

//Word myWord = new Word("Hej, aasdf");
//Word myWord2 = new Word("Hej, aasdf");

WordList myWordList = new WordList("EngSweSpa", "English", "Swedish", "Spanish");

myWordList.Add("Hi","Hej", "Hola");
myWordList.Add("World", "Värld", "Mundo");
myWordList.Add("Car", "Bil", "Coche");
myWordList.Add("Moon", "Måne", "Luna");

//Console.WriteLine("Before remeove count: " + myWordList.Count());
//myWordList.Remove(0, "Hi");
//Console.WriteLine("After Remove count: " + myWordList.Count());

//Console.WriteLine(myWord);
//Console.WriteLine(myWord2);

Console.WriteLine(" - Print out myWordList Test");
myWordList.List(2, PrintTranslations );



Console.WriteLine("\n - Getlists name in folder Test:");
foreach (String name in WordList.GetLists())
{
    Console.WriteLine(name);
}



Console.WriteLine("\n- Load in file Test:");

WordList testLoadList = WordList.LoadList("lang3");
testLoadList.List(0, PrintTranslations);

Console.WriteLine($"\n - SAVE TEST INFO");
myWordList.Save();


Console.WriteLine($"\n - Get word TEST INFO");

GuessTheWORD();





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
