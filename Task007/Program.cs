// Есть массив целых чисел
//написать программу, которая создаст и распечатает массив, сотсоящий только из этих чисел

//0. метод, считывающий число от пользователя из консоли
//1. описать метод, создающий массив с указанным количеством элементов
//2. описать метод, заполняющий массив поэлементно от пользователя
//3. метод подсчета четных элементов
//4. метод, формирующий новый массив на основе имеющегося
//5. метод, печатающий массив

//0
int GetNumber(string text)
{
    Console.WriteLine(text);
    int value = Convert.ToInt32(Console.ReadLine()); 
    // тоже самое Convert.ToInt32()
    return value;
}

//1
int[] CreateArray(int count)
{
    return new int[count];
}


//2
void Fill(int[] array)
{
    int size = array.Length;

    int index = 0;
    while (index<size)
    {
        array[index] = GetNumber($"array[{index}]: ");
        index++;
    }
}


//3
int CountIsEven(int[] elements)
{
    int result = 0;
    int size = elements.Length;
    int i = 0;
    while (i<size)
    {
        if (elements[i] % 2 == 0) result++;
        i++;
    }
    return result;
}


//4
int[] Solution(int[] collectionElements, int evenCounts)
    {
        int[] items = new int[evenCounts];
        int length = collectionElements.Length;
        int position = 0;
        int indexInItems = 0;
        while (position < length)
        {
            if(collectionElements[position] % 2 == 0)
            {
                items[indexInItems] = collectionElements[position];
                indexInItems++;
            }
            position++;
        }
        return items;
    }


//5.1
void PrintBad(int[] numbers)
{
  int size = numbers.Length;
  int i = 0;

  while (i < size)
  {
    Console.Write($"{numbers[i]} ");
    i++;
  }
  Console.WriteLine();
}

//5/2
string PrintGood(int[] numbers)
{
  int size = numbers.Length;
  int i = 0;
  string result = "[ ";

  while (i < size)
  {
    result+= ($"{numbers[i]} ");
    i++;
  }
  return result + "]";
}


// Клиентский код

int countElements = GetNumber("Введите количество элементов массива: ");
int[] arr = CreateArray(countElements);
Fill(arr);
PrintBad(arr);
int even = CountIsEven(arr);
int[] newArr = Solution(arr, even);
Console.WriteLine(PrintGood(newArr));
