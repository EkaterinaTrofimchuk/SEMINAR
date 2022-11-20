// вход принимает два числа и выдаёт, какое число большее, а какое меньшее

Console.WriteLine("Введи первое число");

int A = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введи второе число");

int B = Convert.ToInt32(Console.ReadLine());

if (A > B)
{    
    Console.Write("Первое число ");
    Console.Write(A);
    Console.Write(" больше второго числа ");
    Console.Write(B);
}
    else 
    {
    Console.Write("Второе число ");
    Console.Write(B);
    Console.Write(" больше первого числа ");
    Console.Write(A);;  
    }




