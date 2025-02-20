

        // 1. Пошук другого найбільшого елемента масиву
        int[] array = { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3 };
        Console.WriteLine("Другий найбільший елемент: " + FindSecondLargest(array));

        // 2. Сортування двовимірного масиву за зростанням
        int[,] matrix = {
            { 5, 3, 8 },
            { 1, 4, 7 },
            { 9, 2, 6 }
        };
        SortMatrix(matrix);
        Console.WriteLine("Відсортована матриця:");
        PrintMatrix(matrix);

        // 3. Видалення елемента з масиву за індексом
        int[] newArray = RemoveAtIndex(array, 3);
        Console.WriteLine("Масив після видалення елемента: " + string.Join(", ", newArray));

        // 4. Сума елементів головної діагоналі
        Console.WriteLine("Сума головної діагоналі: " + SumDiagonal(matrix));

    static int FindSecondLargest(int[] arr)
    {
        Array.Sort(arr);
        return arr[arr.Length - 2];
    }

    static void SortMatrix(int[,] matrix)
    {
        int[] sorted = new int[matrix.Length];
        int k = 0;
        foreach (int val in matrix)
            sorted[k++] = val;
        Array.Sort(sorted);
        k = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
            for (int j = 0; j < matrix.GetLength(1); j++)
                matrix[i, j] = sorted[k++];
    }

    static void PrintMatrix(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
                Console.Write(matrix[i, j] + " ");
            Console.WriteLine();
        }
    }

    static int[] RemoveAtIndex(int[] arr, int index)
    {
        int[] newArr = new int[arr.Length - 1];
        for (int i = 0, j = 0; i < arr.Length; i++)
        {
            if (i != index)
                newArr[j++] = arr[i];
        }
        return newArr;
    }

    static int SumDiagonal(int[,] matrix)
    {
        int sum = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
            sum += matrix[i, i];
        return sum;
    }