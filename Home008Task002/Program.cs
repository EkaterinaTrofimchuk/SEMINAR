//Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.


// создание массива
int[,] CreateArray(int row, int pow)
{
  return new int[row, pow];
}

// заполнение массива
void Fill(int[,] array, int min, int max)
{
   for (int row = 0; row < array.GetLength(0); row++)
   {
      for (int pow = 0; pow < array.GetLength(1); pow++)
        {
            array[row,pow] = new Random().Next(min, max);
        }
   }
}

//печать массива
void PrintArray(int[,] array)
{
    for (int row = 0; row < array.GetLength(0); row++)
    {
      for (int pow = 0; pow < array.GetLength(1); pow++)
      {
        Console.Write($"{array[row,pow],4}");
      }
      Console.WriteLine();
    }
}


void SumRow(int[,] array)
{
  for (int row = 0; row < array.GetLength(0); row++)
  {
    int [] sum = new int[array.GetLength(0)];
    sum[row] = 0;

    for (int i=0; i<array.GetLength(1); i++)
    {
      sum[row] = sum[row] + array[row,i];
    }
    Console.WriteLine(sum[row]);
  }
}
     
        
int[,] matrix = CreateArray(4,4);
Fill(matrix,0,14);
PrintArray(matrix);
Console.WriteLine();
SumRow(matrix);
Console.WriteLine();