using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите первое число:");
        double number1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите второе число:");
        double number2 = Convert.ToDouble(Console.ReadLine());

        if (number1 == number2)
        {
            Console.WriteLine("Числа равны");
        }
        else if (number1 > number2)
        {
            Console.WriteLine("Первое число больше второго");
        }
        else
        {
            Console.WriteLine("Первое число меньше второго");
        }
    }
}

