// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях

// метод, который создаёт массив
int[] CreateArray(int count)
  {
    return new int[count];
  }

  // заполняет массив
void Fill(int[] array, int min, int max)
  {
    int size = array.Length;
    for (int i = 0; i < size; i++)
    {
      array[i] = Random.Shared.Next(min, max + 1);
      //array[i] = new Random().Next(min, max);
    }
  }

string PrintGood(int[] numbers)
  {
    int size = numbers.Length;
    int i = 0;
    string result = "[ ";

    while (i < size)
    {
      result += ($"{numbers[i],3} ");
      i++;
    }
    return result + "]";
  }

int SumOddIndex(int[] array)
{
int index = 0;
int sum = 0;
    while (index<array.Length)
    {
        if ((index) % 2 == 1)
        sum = sum + array[index];
        index++;
    }
    return sum;
}

int[] col = CreateArray(12);
Fill(col, 0, 100);
Console.WriteLine(PrintGood(col));
int sumRes = SumOddIndex(col);
Console.WriteLine(sumRes);