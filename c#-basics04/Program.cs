
// 11st answer 
using System;

class Program
{
    static void Main()
    {
        PrintBookInfo(pages: 352, title: "Domain-Driven Design");
    }

    static void PrintBookInfo(string title, int pages = 300)
    {
        Console.WriteLine($"Book: {title}, Pages: {pages}");
    }
}