// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным

Console.WriteLine("Введите число:");
int a = Convert.ToInt32(Console.ReadLine());

if (a%2 == 0)
{
    Console.Write("Введенное число четное ");
}
else
{
    Console.Write("Введенное число нечетное ");
}