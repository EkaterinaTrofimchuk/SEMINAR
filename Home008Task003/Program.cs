// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел

int[,,] arr = new int [3,4,5];
arr [1,2,3] = 3;
for (int row = 0; row < arr.GetLength(0); row++)
{
    for (int columns = 0; columns < arr.GetLength(1); columns++)
    {
        for (int side = 0; side < arr.GetLength(2); side++)
        {
            Console.WriteLine($"{arr[row, columns, side]}({row},{columns},{side})");
        }
    }
}