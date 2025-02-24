
using System;

class Program
{

    static void Main()
    {
        string report = "Звіт про події\n";

        string currentDate = DateTime.Now.ToString("yyyy-MM-dd");
        report += $"Дата: {currentDate}\n";

        report += "\nСписок подій:\n";

        string eventInput;
        int eventCount = 1;

        Console.WriteLine("Введіть події (для завершення введіть 'stop'):");

        // Цикл для введення подій
        while (true)
        {
            Console.Write($"Подія {eventCount}: ");
            eventInput = Console.ReadLine();

            if (eventInput.ToLower() == "стоп")
            {
                break;
            }

            report += $"- {eventInput}\n";
            eventCount++;
        }

        Console.WriteLine("\nГотовий звіт:");
        Console.WriteLine(report);
    }
}
