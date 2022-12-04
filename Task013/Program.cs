// Написать программу, которая в двумерном массиве заменяет строки на столбцы или сообщить, что это невозможно (в случае, если матрица не квадратная).


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

// метод замены
int[,] ReplaceElem(int[,] array)
{
int[,] newMatrix = new int[array.GetLength(0), array.GetLength(1)];
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        newMatrix[i,j] = array[j,i];
    }
}
return newMatrix;
}


int[,] col = CreateArray(6,7);
Fill(col, 0, 14);
PrintArray(col);
Console.WriteLine();

int row = col.GetLength(0);
int pow = col.GetLength(1);
if (row!= pow)
    {
    Console.WriteLine("невозможно заменить");
    }
else PrintArray(ReplaceElem(col));