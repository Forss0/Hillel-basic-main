
using System;
using System.IO;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8; 

        try
        {
            Console.Write("Введите путь к исходному файлу: ");
            string sourcePath = Console.ReadLine();

            if (!File.Exists(sourcePath))
            {
                Console.WriteLine("Ошибка: Исходный файл не найден.");
                return;
            }

            Console.Write("Введите путь к файлу назначения: ");
            string destinationPath = Console.ReadLine();

            File.Copy(sourcePath, destinationPath, true);
            Console.WriteLine("Файл успешно скопирован!");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }
    }
}
