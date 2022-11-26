// сколько раз каждое число повторяется в заданном массиве 

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

// печать массив
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

void SelectionSort(int[] array)
{
    for (int i=0; i<array.Length-1; i++)
    {
        int minPosition = i;
        
        for (int j=i+1; j<array.Length; j++)
        {
            if(array[j]<array[minPosition]) minPosition = j;
        }
        
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}

// Метод подсчёта количества чисел
void CountMethod(int[] col)
{
    for (int i = 0; i < 15; i++)
    {
        int count = 0;
        for(int j = 0; j <= 9; j ++)
        {
            if(i == col[j])
            count++;
        }
        Console.WriteLine($"{i} - {count} раз(а) ");
    }
}


int[] col = CreateArray(10);
Console.WriteLine(PrintGood(col));
Fill(col, 0, 14);
Console.WriteLine(PrintGood(col));
SelectionSort(col);
Console.WriteLine(PrintGood(col));
CountMethod(col);



