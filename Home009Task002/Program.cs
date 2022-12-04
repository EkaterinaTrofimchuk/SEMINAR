// Задайте значения M и N. Напишите программу, 
//которая найдёт сумму натуральных элементов в промежутке от M до N.

int SumRec (int m, int n)
{
    int sum = 0;
    int innerRec(int innM, int innN)
    {
        if (innM <= innN) {
            sum += innM;
            return innerRec(innM + 1, innN);
        } else {
            return sum;
        }
    }

    return innerRec(m, n);
}

Console.WriteLine(SumRec(4,10));