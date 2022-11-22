// Напишите программу, кторая выводит случайное трехзначное число и удаляет вторую цифру этого числа

//1. Сгенерировать число
//2.Разбить число на цифры
//3. Составить новое число
//4. Показать его на экране

int value = new Random().Next(100,1000);
int a = value / 100;
int b = (value / 10) % 10;
int c = value % 10;

int result = a * 10 + c;

Console.WriteLine(value);
Console.WriteLine(result);
