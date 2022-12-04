// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива

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
      array[row,pow] = Random.Shared.Next(min, max + 1);
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


void SelectionSort(int[,] array)
{
  for (int row = 0; row < array.GetLength(0); row++)
  {
    for (int i=0; i<array.GetLength(1)-1; i++)
    {
        int maxPosition = i;
        
        for (int j=i+1; j<array.GetLength(1); j++)
        {
            if(array[row,j]>array[row,maxPosition]) maxPosition = j;
        }
        
        int temporary = array[row, i];
        array[row,i] = array[row,maxPosition];
        array[row,maxPosition] = temporary;
    }
  }
}

        
        
int[,] matrix = CreateArray(3,4);
Fill(matrix, 0, 14);
PrintArray(matrix);
Console.WriteLine();
SelectionSort(matrix);
PrintArray(matrix);
Console.WriteLine();

