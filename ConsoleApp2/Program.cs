using System;

class Program
{
    static int Division(int a, int b)
    {
        if (b == 0)
        {
            throw new DivideByZeroException("Ділення на нуль неможливе.");
        }
        return a / b;
    }

    static void Main()
    {
        try
        {
            Console.Write("Введіть число A: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Введіть число B: ");
            int b = int.Parse(Console.ReadLine());

            int result = Division(a, b);
            Console.WriteLine($"Частка: {result}");
        }
        catch (DivideByZeroException e)
        {
            Console.WriteLine(e.Message);
        }
        catch (FormatException)
        {
            Console.WriteLine("Помилка: введено некоректні дані.");
        }
    }
}
