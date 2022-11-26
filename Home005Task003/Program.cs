//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива

// double d = Random.Shared.NextDouble();
// Console.WriteLine("{d}:f2");

// метод, который создаёт массив
double[] CreateArray(int count)
  {
    return new double[count];
  }

  // заполняет массив
void Fill(double[] array)
  {
    int size = array.Length;
    for (int i = 0; i < size; i++)
    {
      array[i] = Random.Shared.NextDouble();
      //array[i] = new Random().Next(min, max);
    }
  }

string PrintGood(double[] numbers)
  {
    int size = numbers.Length;
    int i = 0;
    string result = "[ ";

    while (i < size)
    {
      result += (string.Format("{0:F3}   ",numbers[i]));
      i++;
    }
    return result + "]";
  }

// метод нахождения макcимального значения
double NumberMax (double[] numbers)
{
    int ind = 0;
    double max = numbers[0];
    while (ind < numbers.Length)
    {
        if (numbers[ind] > max)
        {
            max = numbers[ind];
        }
        ind++;
    }
return max;
}

// метод нахождения минимального значения
double NumberMin (double[] numbers)
{
    int ind = 0;
    double min = numbers[0];
    while (ind < numbers.Length)
    {
        if (numbers[ind] < min)
        {
            min = numbers[ind];
        }
        ind++;
    }
return min;
}

double[] col = CreateArray(10);
Fill(col);
Console.WriteLine(PrintGood(col));
double maxRes = NumberMax(col);
Console.WriteLine(string.Format("{0:F3}   ",maxRes));
double minRes = NumberMin(col);
Console.WriteLine(string.Format("{0:F3}   ",minRes));
double res = maxRes - minRes;
Console.WriteLine(string.Format("{0:F3}",res));