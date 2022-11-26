// Напишите метод, который принимает на вход число и выдаёт сумму цифр в числе

int number = new Random().Next();
Console.WriteLine(number);

int sum = 0;

while (number>0)
{
sum = sum + (number % 10);
number = number / 10;
}

Console.WriteLine(sum);