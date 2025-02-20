
using System.Text;

Console.OutputEncoding = Encoding.Unicode;

Console.Write("Введіть ім'я та прізвище: ");
string fullName = Console.ReadLine();

string[] parts = fullName.Split(' ');
if (parts.Length < 2)
{
    Console.WriteLine("Будь ласка, введіть і ім'я, і прізвище.");
    return;
}

char firstLetterName = char.ToLower(parts[0][0]);
char firstLetterSurname = char.ToLower(parts[1][0]);

if (firstLetterName == firstLetterSurname)
{
    Console.WriteLine("Прізвище починається на ту ж літеру, що і ім’я");
}
else
{
    Console.WriteLine("Прізвище не починається на ту ж літеру, що і ім’я");
}