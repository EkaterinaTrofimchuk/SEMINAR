// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N

Console.WriteLine("Введите число N");
int N = Convert.ToInt32(Console.ReadLine());

int a = 1;

while(a<=N)
{
if(a%2==0)
    {
        Console.Write(a+",");
        a = a + 2;
    }
else a=a+1;
}

