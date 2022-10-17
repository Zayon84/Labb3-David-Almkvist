// C# Labb3 – Utveckla en applikation för att träna glosor. 
// David Almvkvist - Oct 2022
using Word_Library;

Console.WriteLine("\t\tLabb3 – Utveckla en applikation för att träna glosor.\n");

Word myWord = new Word("Hej, aasdf");
Word myWord2 = new Word("Hej, aasdf");

WordList myWordList = new WordList("EngSweSpa", "English", "Swedish", "Spanish");

myWordList.Add("Hi","Hej", "Hola");
myWordList.Add("World","Värld", "Mundo");

Console.WriteLine("Before remeove count: " + myWordList.Count());
myWordList.Remove(0, "Hi");
Console.WriteLine("After Remove count: " + myWordList.Count());

Console.WriteLine(myWord);
Console.WriteLine(myWord2);

Console.WriteLine("\nGetlists name in folder:");
foreach (String name in WordList.GetLists())
{
    Console.WriteLine(name);
}

