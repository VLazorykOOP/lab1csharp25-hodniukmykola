using System;

class Program
{
    static void Main()
    {

        Console.Write("Введіть перше число: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введіть друге число: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        double avgCubes = (Math.Pow(num1, 3) + Math.Pow(num2, 3)) / 2;

        Console.WriteLine($"Середнє арифметичне кубів: {avgCubes}");
    }
}
