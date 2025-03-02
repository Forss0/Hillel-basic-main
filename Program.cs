
using System;
using System.Collections.Generic;
using System.Text;

class Hangman
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        string word = "home";
        char[] hiddenWord = new char[word.Length];
        for (int i = 0; i < hiddenWord.Length; i++) hiddenWord[i] = '_';
        int attempts = 6;
        HashSet<char> guessedLetters = new HashSet<char>();

        Console.WriteLine("Вітаємо! Спробуйте вгадати зашифроване слово!");
        Console.WriteLine("Кількість літер у слові: " + word.Length);
        Console.WriteLine("Кількість можливих невірних спроб: " + attempts);

        while (Array.Exists(hiddenWord, ch => ch == '_') && attempts > 0)
        {
            Console.WriteLine("\nСлово: " + string.Join(" ", hiddenWord));
            Console.Write("Введіть вашу літеру: ");
            string input = Console.ReadLine().Trim().ToLower();

            // Перевірка на введення однієї літери
            if (input.Length != 1 || !char.IsLetter(input[0]))
            {
                Console.WriteLine("❌ Помилка! Введіть лише одну літеру.");
                continue;
            }

            char letter = input[0];

            // Перевірка, чи ця літера вже вводилася
            if (guessedLetters.Contains(letter))
            {
                Console.WriteLine(" Ви вже вводили цю літеру!");
                continue;
            }

            guessedLetters.Add(letter);
            bool found = false;
            List<int> positions = new List<int>();

            // Перевірка, чи є літера в слові
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == letter)
                {
                    hiddenWord[i] = letter;
                    found = true;
                    positions.Add(i + 1);
                }
            }

            if (found)
            {
                Console.WriteLine($"✅ Літера '{letter}' є у слові! Позиції: {string.Join(", ", positions)}");
            }
            else
            {
                attempts--;
                Console.WriteLine($"❌ Такої літери немає! Залишилось спроб: {attempts}");
            }
        }

        // Перевірка результату гри
        if (!Array.Exists(hiddenWord, ch => ch == '_'))
        {
            Console.WriteLine($"\n Вітаємо, ви вгадали слово! Зашифроване слово: {word}");
        }
        else
        {
            Console.WriteLine($"\n Ви програли. Загадане слово було: {word}");
        }

        Console.WriteLine(" Дякуємо за гру!");
        Console.ReadKey();
    }
}
