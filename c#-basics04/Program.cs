
// 8st answer 
using System;

class Program
{
    static void Main()
    {
        double[] prices = { 25.5, 40.0 };
        ReplaceArray(ref prices);
        Console.WriteLine(prices.Length);
    }

    static void ReplaceArray(ref double[] prices)
    {
        prices = new double[] { 10.0, 12.5, 15.0 };
    }
}