
// 9st answer 
using System;

class Program
{
    static void Main()
    {
        if (TryGetPrice("Clean Code", out double price))
        {
            Console.WriteLine(price); 
        }
    }

    static bool TryGetPrice(string title, out double price)
    {
        if (title == "Clean Code")
        {
            price = 25.5;
            return true;
        }

        price = 0;
        return false;
    }
}