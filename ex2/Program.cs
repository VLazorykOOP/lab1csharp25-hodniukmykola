using System;

class Program
{
    static void Main()
    {
        Console.Write("Введіть число M: ");
        int M = int.Parse(Console.ReadLine());

        Console.Write("Введіть число N: ");
        int N = int.Parse(Console.ReadLine());

        if (N == 0)
        {
            Console.WriteLine("Ділення на нуль неможливе.");
        }
        else if (M % N == 0)
        {
            Console.WriteLine($"Частка від ділення: {M / N}");
        }
        else
        {
            Console.WriteLine("M на N націло не ділиться");
        }
    }
}
