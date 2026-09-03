
// 6st answer 
using System;

class Program
{
    static void Main()
    {
        double[] prices = { 25.5, 40.0 };
        ApplyDiscount(prices);
        Console.WriteLine(prices[0]); // 20.5
    }

    static void ApplyDiscount(double[] prices)
    {
        prices[0] -= 5;
    }
}