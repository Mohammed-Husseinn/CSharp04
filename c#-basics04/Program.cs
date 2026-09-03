
// 10st answer 
using System;

class Program
{
    static void Main()
    {
        PrintBookInfo("The Pragmatic Programmer");
        PrintBookInfo("Clean Code", 464);
    }

    static void PrintBookInfo(string title, int pages = 300)
    {
        Console.WriteLine($"Book: {title}, Pages: {pages}");
    }
}