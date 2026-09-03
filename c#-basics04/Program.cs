
// 7st answer 
using System;

class Program
{
    static void Main()
    {
        int pages = 400;
        AddBonusPagesByRef(ref pages);
        Console.WriteLine(pages); // 450
    }

    static void AddBonusPagesByRef(ref int pages)
    {
        pages += 50;
    }
}