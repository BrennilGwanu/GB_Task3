// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine()!);

int rem = number % 2;
if (rem==0)
{
    Console.WriteLine("Это число чётное ");
}
else 
{
    Console.WriteLine("Это число нечётное ");
}
