// Напишите методы, который задаёт массив из 8 элементов и выводит их на экран

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

int[] col = CreateArray(8);
Fill(col, 0, 20);
Console.WriteLine(PrintGood(col));
