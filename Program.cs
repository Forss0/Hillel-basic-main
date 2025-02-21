
using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.Unicode;

        Console.Write("Введіть рядок: ");
        string input = Console.ReadLine()?.Replace(" ", "");

        Console.WriteLine("Результат: " + input);
    }
}
