// Задача 2: Напишите программу замена элементов
// массива: положительные элементы замените на 
// соответствующие отрицательные, и наоборот.

// int[] col2 = CreateArray(10);
// Console.WriteLine(PrintGood(col2));
// Fill(col2, -20, 20);
// Console.WriteLine(PrintGood(col2));

// int[] res = Inverse1(col2);
// Inverse2(col2);
// Console.WriteLine(PrintGood(res));
// Console.WriteLine(PrintGood(col2));

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

//меняем знак сразу, без двойной записи
void Inverse2(int[] input)
  {
    int size = input.Length;
    for (int i = 0; i < size; i++)
    {
      input[i] = -input[i];
    }
  }

int[] col = CreateArray(15);
Console.WriteLine(PrintGood(col));
Fill(col, -15, 16);
Console.WriteLine(PrintGood(col));
Inverse2(col);
Console.WriteLine(PrintGood(col));