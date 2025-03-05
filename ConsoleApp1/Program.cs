using System;

class Program
{
    static void Main()
    {
        Console.Write("Введіть номер карти (6-14): ");
        int k = int.Parse(Console.ReadLine());

        string cardName = k switch
        {
            14 => "Туз",
            13 => "Король",
            12 => "Дама",
            11 => "Валет",
            10 => "Десятка",
            9 => "Дев’ятка",
            8 => "Вісімка",
            7 => "Сімка",
            6 => "Шістка",
            _ => "Невідомий номер карти"
        };

        Console.WriteLine($"Назва карти: {cardName}");
    }
}
