// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива

// 1. Ввести рандомно массив длиной 12 из диапазона [-9,9]
//2. проверить все числа массива на знак 
//3. в sum1 записать сумму всех положительных чисел
//4. в sum2 записать сумму всех отрицательных чисел


// Задача 1: Задайте массив из 12 элементов, 
// заполненный случайными числами из промежутка [-9, 9].
// Найдите сумму отрицательных и положительных элементов массива.

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

int SumPositive(int[] numbers)
{
  int result = 0;
  int size = numbers.Length;
  for (int i = 0; i < size; i++)
  {
    if (numbers[i] > 0) result += numbers[i];
  }
  return result;
}

int SumNegative(int[] numbers)
{
  int result = 0;
  int size = numbers.Length;
  for (int i = 0; i < size; i++)
  {
    if (numbers[i] < 0) result += numbers[i];
  }
  return result;
}

// 
int[] col = CreateArray(12);
Console.WriteLine(PrintGood(col));
Fill(col, -9, 9);
Console.WriteLine(PrintGood(col));
int pos = SumPositive(col);
Console.WriteLine($">0 {pos}");
int neg = SumNegative(col);
Console.WriteLine($"<0 {neg}");


// int sum1 = 0;
// int sum2 = 0;

// while ind < array.Length
// {
// if(array[ind]>0) sum1 = sum1 + array[ind];
// else sum2 = sum2 + array[ind];
// ind++;
// }