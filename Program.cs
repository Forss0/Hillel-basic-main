
        // 1. Створення масиву та виведення елементів з парними індексами
        Random random = new Random();
        int[] array = new int[10];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(-10, 11);
        }
        Console.WriteLine("Масив: " + string.Join(", ", array));
        Console.Write("Елементи з парними індексами: ");
        for (int i = 0; i < array.Length; i += 2)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();

        // 2. Перевірка, чи є сума елементів масиву невід'ємною
        int sum = 0;
        foreach (int num in array)
        {
            sum += num;
        }
        Console.WriteLine("Сума елементів масиву " + (sum >= 0 ? "невід'ємна" : "від'ємна"));

        // 3. Створення таблиці множення 9x9
        int[,] multiplicationTable = new int[9, 9];
        for (int i = 0; i < 9; i++)
        {
            for (int j = 0; j < 9; j++)
            {
                multiplicationTable[i, j] = (i + 1) * (j + 1);
                Console.Write(multiplicationTable[i, j].ToString().PadLeft(3) + " ");
            }
            Console.WriteLine();
        }

        // 4. Двовимірний масив 5x5 і знаходження мін/макс значень з координатами
        int[,] matrix = new int[5, 5];
        int min = int.MaxValue, max = int.MinValue;
        int minX = 0, minY = 0, maxX = 0, maxY = 0;

        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                matrix[i, j] = random.Next(-50, 51);
                Console.Write(matrix[i, j].ToString().PadLeft(4));
                if (matrix[i, j] < min)
                {
                    min = matrix[i, j];
                    minX = i;
                    minY = j;
                }
                if (matrix[i, j] > max)
                {
                    max = matrix[i, j];
                    maxX = i;
                    maxY = j;
                }
            }
            Console.WriteLine();
        }
        Console.WriteLine($"Максимальний елемент: {max} (координати [{maxX}, {maxY}])");
        Console.WriteLine($"Мінімальний елемент: {min} (координати [{minX}, {minY}])");

        // 5. Програма з enum для визначення дня тижня
        Console.Write("Введіть кількість днів: ");
        int days = int.Parse(Console.ReadLine());
        DayOfWeek startDay = DayOfWeek.Monday;
        DayOfWeek resultDay = (DayOfWeek)(((int)startDay + days) % 7);
        Console.WriteLine($"Через {days} днів буде {resultDay}");

    enum DayOfWeek
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }