
// 5st answer 
using System;

class Program
{
    static void Main()
    {
        int pages = 400;
        AddBonusPages(pages);
        Console.WriteLine(pages); // 400
    }

    static void AddBonusPages(int pages)
    {
        pages += 50;
    }
}