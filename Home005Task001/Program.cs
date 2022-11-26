// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

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

int EvenCount(int[] array)
{
int index = 0;
int count = 0;
    while (index<array.Length)
    {
        if ((array[index]) % 2 == 0)
        count ++;
        index++;
    }
    return count;
}

int[] col = CreateArray(10);
Fill(col, 0, 1000);
Console.WriteLine(PrintGood(col));
int countRes = EvenCount(col);
Console.WriteLine(countRes);