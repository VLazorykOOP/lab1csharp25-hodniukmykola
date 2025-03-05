using System;

class Program
{
    static void Main()
    {
        Console.Write("Введіть координату x: ");
        double x = double.Parse(Console.ReadLine());

        Console.Write("Введіть координату y: ");
        double y = double.Parse(Console.ReadLine());

        double r = Math.Sqrt(x * x + y * y);
        double R_inner = 3;
        double R_outer = 8;

        if (r > R_inner && r < R_outer && x <= 0)
        {
            Console.WriteLine("Так");
        }
        else if (r == R_inner || r == R_outer || (x == 0 && y >= -8 && y <= 8))
        {
            Console.WriteLine("На межі");
        }
        else
        {
            Console.WriteLine("Ні");
        }
    }
}
