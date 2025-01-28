
Console.Write("Enter the first number: ");
int firstNumber = int.Parse(Console.ReadLine());  // Читання першого числа

Console.Write("Enter the second number: ");
int secondNumber = int.Parse(Console.ReadLine());  // Читання другого числа

Console.Write("Enter an operation (+, -, *, /): ");
string operation = Console.ReadLine();  // Читання операції

// Виконання обраної операції
if (operation == "+")
{
    Console.WriteLine("Result: " + (firstNumber + secondNumber));
}
else if (operation == "-")
{
    Console.WriteLine("Result: " + (firstNumber - secondNumber));
}
else if (operation == "*")
{
    Console.WriteLine("Result: " + (firstNumber * secondNumber));
}
else if (operation == "/")
{
    if (secondNumber != 0)
    {
        Console.WriteLine("Result: " + (firstNumber / (double)secondNumber));
    }
    else
    {
        Console.WriteLine("Division by zero is not allowed");
    }
}