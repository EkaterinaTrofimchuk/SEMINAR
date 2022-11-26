// Напишите метод, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

Console.WriteLine("Введи первое число");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введи второе число");
int B = Convert.ToInt32(Console.ReadLine());
int i = 0;
int St = 1;

while (i<B)
{
St = St*A;
i++;
}

Console.Write($" результат возведения в степень равен {St}");


