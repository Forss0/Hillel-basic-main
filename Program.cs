
using System;
using System.Text;

public static class FibonacciCalculator
{
    public static int Fibonacci(int n)
    {
        if (n < 0)
            throw new ArgumentException("Число повинно бути невід'ємним", nameof(n));

        if (n == 0) return 0;
        if (n == 1) return 1;

        return Fibonacci(n - 1) + Fibonacci(n - 2);
    }

    public static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.Write("Введіть номер числа Фібоначчі: ");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine($"Число Фібоначчі ({number}) = {Fibonacci(number)}");
    }
}