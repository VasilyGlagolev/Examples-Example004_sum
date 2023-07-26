using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите первое число: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Введите второе число: ");
        int b = int.Parse(Console.ReadLine());

        if (a > b)
        {
            Console.WriteLine($"Максимальное число: {a}");
            Console.WriteLine($"Минимальное число: {b}");
        }
        else
        {
            Console.WriteLine($"Максимальное число: {b}");
            Console.WriteLine($"Минимальное число: {a}");
        }

        Console.ReadKey();
    }
}

