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

Console.WriteLine("- Print out myWordList Test");
myWordList.List(2, PrintTranslations );



Console.WriteLine("\n- Getlists name in folder Test:");
foreach (String name in WordList.GetLists())
{
    Console.WriteLine(name);
}



Console.WriteLine("\n- Load in file Test:");

WordList testLoadList = WordList.LoadList("lang3");
testLoadList.List(0, PrintTranslations);



void PrintTranslations(string[] translations)
{
    foreach (string currentString in translations)
    {
        Console.Write(currentString + " ");
        
    }
    Console.WriteLine();
}
