// Напишите программу вычисления функции Аккермана с помощью рекурсии. 

int recursion(int m, int n)
    {
        if (m == 0)
        {
            return n + 1;
        } 
        else if (n == 0 && m > 0)
        {
            return recursion(m - 1, 1);
        } 
        else
        {
            return recursion(m - 1, recursion(m, n - 1));
        }
    }
    

Console.WriteLine("Введи первое число");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введи второе число");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write(recursion(m, n)); 

       



