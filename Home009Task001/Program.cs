// Задайте значение N. Напишите программу, которая выведет все 
//натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

string NumbersRec(int N, int b)
{
    if (N<=b) return NumbersRec(N+1, b) + $"{N}  ";
    else return string.Empty;
}

Console.WriteLine(NumbersRec(1,8));
