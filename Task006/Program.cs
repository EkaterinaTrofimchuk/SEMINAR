﻿// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

// 1.Вводим два числа
// 2.Находим квадрат первого числа и проверяем равенству второму числу
// 3. Находим квадрат второго числа и проверяем равенство первому число
// 4. Если равеснтво Истина, то выводим: ДА
// 5. Если равенство Ложь, то выводим: НЕТ

int a = 100;
int b = 10;

if(a == b*b)
{
    Console.WriteLine("Первое число - это квадрат второго");
}
else if(b == a*a)
{
    Console.WriteLine("Второе число - это квадрат первого");
}
else
{
    Console.WriteLine("Ни одно число не является квадратом другого");
}