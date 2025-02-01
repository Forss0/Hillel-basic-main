
try
{
    Console.Write("Enter a number: ");
    double number = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine($"Valid number: {number}");
}
catch
{
    Console.WriteLine("Error: Invalid input");
}
finally
{
    Console.WriteLine("Program finished.");
}