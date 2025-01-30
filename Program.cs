
Console.Write("Enter numerator: ");
double a = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter denominator: ");
double b = Convert.ToDouble(Console.ReadLine());

Console.WriteLine(b == 0 ? "Error: Division by zero" : $"Result: {a / b}");