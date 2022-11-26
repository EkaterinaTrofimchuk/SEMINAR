// Задача 3: Задайте массив.
// Напишите программу, которая определяет, 
// присутствует ли заданное число в массиве.

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

int upperBound = 50;
int searchElement = Random.Shared.Next(0, upperBound);

bool FindElement1(int[] col, int find)
  {
    int size = col.Length;
    for (int i = 0; i < size; i++)
    {
      if (col[i] == find) return true;
    }
    return false;
  }

int[] col = CreateArray(15);
Console.WriteLine(PrintGood(col));
Fill(col, -15, 16);
Console.WriteLine(PrintGood(col));
bool flag1 = FindElement1(col, searchElement);
Console.WriteLine($"{searchElement} найден - {flag1}");
