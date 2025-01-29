
// Запит на введення першого числа
Console.Write("Enter the first number: ");
if (int.TryParse(Console.ReadLine(), out int firstNumber))
{
    // Запит на введення другого числа
    Console.Write("Enter the second number: ");
    if (int.TryParse(Console.ReadLine(), out int secondNumber))
    {
        // Запит на введення операції
        Console.Write("Enter an operation (+, -, *, /): ");
        string operation = Console.ReadLine();

        // Виконання обчислень операції
        switch (operation)
        {
            case "+":
                Console.WriteLine("Result: " + (firstNumber + secondNumber));
                break;
            case "-":
                Console.WriteLine("Result: " + (firstNumber - secondNumber));
                break;
            case "*":
                Console.WriteLine("Result: " + (firstNumber * secondNumber));
                break;
            case "/":
                if (secondNumber != 0)
                    Console.WriteLine("Result: " + (firstNumber / (double)secondNumber));
                else
                    Console.WriteLine("Error: Division by zero");
                break;
            default:
                Console.WriteLine("Invalid operation");
                break;
        }
    }
    else
    {
        // Обробка некоректного введення другого числа
        Console.WriteLine("Invalid input for the second number");
    }
}
else
{
    // Обробка некоректного введення першого числа
    Console.WriteLine("Invalid input for the first number");
}