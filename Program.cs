
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        AverageSalary();
        StarGraph();
        GeneratePrimes();
        PasswordCheck();
        FibonacciSequence();
        HourlyWageCalculator();
        ReverseString();
        IsPalindrome();
    }

    // 1. Обчислення середнього заробітку
    static void AverageSalary()
    {
        double sum = 0;
        int count = 0;
        Console.WriteLine("Введіть зарплати працівників (введіть 0 для завершення):");

        while (true)
        {
            Console.Write("Зарплата: ");
            string input = Console.ReadLine();
            if (Regex.IsMatch(input, "^\\d+(\\.\\d+)?$"))
            {
                double salary = Convert.ToDouble(input);
                if (salary == 0) break;
                sum += salary;
                count++;
            }
            else
            {
                Console.WriteLine("Некоректний ввід, спробуйте ще раз.");
            }
        }

        double average = count > 0 ? sum / count : 0;
        Console.WriteLine($"Середній заробіток: {average}\n");
    }

    // 2. Побудова графіку зірочками
    static void StarGraph()
    {
        Console.Write("Введіть кількість рядків: ");
        string input = Console.ReadLine();
        if (Regex.IsMatch(input, "^\\d+$"))
        {
            int rows = Convert.ToInt32(input);
            for (int i = 1; i <= rows; i++)
            {
                Console.WriteLine(new string('*', i));
            }
        }
        else
        {
            Console.WriteLine("Некоректний ввід.");
        }
        Console.WriteLine();
    }

    // 3. Генерація простих чисел
    static void GeneratePrimes()
    {
        Console.Write("Введіть верхню межу для генерації простих чисел: ");
        string input = Console.ReadLine();
        if (Regex.IsMatch(input, "^\\d+$"))
        {
            int limit = Convert.ToInt32(input);
            Console.WriteLine("Прості числа:");
            for (int i = 2; i <= limit; i++)
            {
                if (IsPrime(i))
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine("\n");
        }
        else
        {
            Console.WriteLine("Некоректний ввід.");
        }
    }

    static bool IsPrime(int number)
    {
        if (number < 2) return false;
        for (int i = 2; i * i <= number; i++)
        {
            if (number % i == 0) return false;
        }
        return true;
    }

    // 4. Перевірка паролю
    static void PasswordCheck()
    {
        Console.Write("Введіть пароль: ");
        string password = Console.ReadLine();
        Regex regex = new Regex("^(?=.*\\d)(?=.*[!@#$%^&*])[A-Za-z\\d!@#$%^&*]{8,}$");

        if (regex.IsMatch(password))
            Console.WriteLine("Пароль прийнятний.\n");
        else
            Console.WriteLine("Пароль не відповідає вимогам.\n");
    }

    // 5. Генерація фібоначчівської послідовності
    static void FibonacciSequence()
    {
        Console.Write("Введіть кількість чисел Фібоначчі: ");
        string input = Console.ReadLine();
        if (Regex.IsMatch(input, "^\\d+$"))
        {
            int n = Convert.ToInt32(input);
            int first = 0, second = 1;

            // Якщо кількість чисел Фібоначчі 1, виводимо лише перше число
            if (n >= 1)
                Console.Write(first + " ");

            // Якщо кількість чисел Фібоначчі 2 або більше, виводимо друге число
            if (n >= 2)
                Console.Write(second + " ");

            // Для кожного наступного числа
            for (int i = 3; i <= n; i++)
            {
                int next = first + second;
                Console.Write(next + " ");
                first = second;   // Переміщаємо друге число в перше
                second = next;    // Переміщаємо нове число в друге
            }
            Console.WriteLine("\n");
        }
        else
        {
            Console.WriteLine("Некоректний ввід.");
        }
    }

    // 6. Калькулятор оплати праці за годину
    static void HourlyWageCalculator()
    {
        Console.Write("Введіть кількість годин, відпрацьованих за день: ");
        string hoursInput = Console.ReadLine();
        Console.Write("Введіть погодинну ставку: ");
        string rateInput = Console.ReadLine();

        if (Regex.IsMatch(hoursInput, "^\\d+(\\.\\d+)?$") && Regex.IsMatch(rateInput, "^\\d+(\\.\\d+)?$"))
        {
            double hours = Convert.ToDouble(hoursInput);
            double rate = Convert.ToDouble(rateInput);
            Console.WriteLine($"Оплата за день: {hours * rate}\n");
        }
        else
        {
            Console.WriteLine("Некоректний ввід.");
        }
    }

    // 7. Реверсування рядка
    static void ReverseString()
    {
        Console.Write("Введіть рядок для реверсування: ");
        string input = Console.ReadLine();
        char[] charArray = input.ToCharArray();
        Array.Reverse(charArray);
        Console.WriteLine($"Реверсований рядок: {new string(charArray)}\n");
    }

    // 8. Перевірка на паліндром
    static void IsPalindrome()
    {
        Console.Write("Введіть рядок для перевірки на паліндром: ");
        string input = Console.ReadLine();
        string reversed = new string(input.Reverse().ToArray());

        if (input.Equals(reversed, StringComparison.OrdinalIgnoreCase))
            Console.WriteLine("Це паліндром.\n");
        else
            Console.WriteLine("Це не паліндром.\n");
    }
}