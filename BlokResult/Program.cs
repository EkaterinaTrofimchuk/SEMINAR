// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам.

string[] array = new string[] {"Hello", "2", "world", ":-)"};
string[] arrayNew = new string[array.Length];

//метод создания нового массива
void SecondArrayWithIF(string[] array, string[] arrayNew)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
    if(array[i].Length <= 3)
        {
        arrayNew[count] = array[i];
        count++;
        }
    }
}

// метод печати
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