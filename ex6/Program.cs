using System;

class Program
{
    static void Main()
    {
        Console.Write("Введіть значення a: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Введіть значення b: ");
        double b = double.Parse(Console.ReadLine());

        double denominator = a * a + b * b; // знаменник

        if (denominator == 0)
        {
            Console.WriteLine("Помилка: знаменник дорівнює нулю, ділення неможливе.");
        }
        else
        {
            double numerator = (a * b) + ((a - b) * (a + b)) - 1; // чисельник
            double result = (numerator / denominator) - 5;

            Console.WriteLine($"Результат: {result}");
        }
    }
}
