
// 12st answer 
using System;

class Program
{
    static void Main()
    {
        PrintAllTitles("Clean Code", "The Pragmatic Programmer", "Refactoring");
    }

    static void PrintAllTitles(params string[] titles)
    {
        foreach (string title in titles)
        {
            Console.WriteLine(title);
        }
    }
}