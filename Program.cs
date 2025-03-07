
using System;
using System.Collections.Generic;
using System.Text;

class Program
{
    static List<string> tasks = new List<string>();

    static void Main()
    {
        Console.OutputEncoding = Encoding.Unicode;
        LoadTasks();
        while (true)
        {
            Console.WriteLine("\n1. Додати справу\n2. Вивести список\n3. Видалити справу\n4. Вихід");
            string choice = Console.ReadLine();
            if (choice == "1") AddTask();
            else if (choice == "2") ShowTasks();
            else if (choice == "3") RemoveTask();
            else if (choice == "4") break;
        }
    }

    static void LoadTasks()
    {
        if (tasks.Count > 0)
        {
            Console.WriteLine("\nЗбережений список справ:");
            ShowTasks();
        }
        else
        {
            Console.WriteLine("\nСписок справ порожній.");
        }
    }

    static void AddTask()
    {
        Console.Write("Введіть справу: ");
        tasks.Add(Console.ReadLine());
    }

    static void ShowTasks()
    {
        if (tasks.Count == 0)
        {
            Console.WriteLine("Список справ порожній.");
            return;
        }
        for (int i = 0; i < tasks.Count; i++)
            Console.WriteLine($"{i + 1}. {tasks[i]}");
    }

    static void RemoveTask()
    {
        ShowTasks();
        Console.Write("Введіть номер: ");
        if (int.TryParse(Console.ReadLine(), out int index) && index > 0 && index <= tasks.Count)
            tasks.RemoveAt(index - 1);
    }
}
