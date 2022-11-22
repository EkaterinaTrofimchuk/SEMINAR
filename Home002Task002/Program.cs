// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 1. Вводим число
// 2. Если число меньше 99, то выводим: третьей цифры нет
//3. Если число больше 99, то каждую цифру преобразуем в строку Convert.ToString
//4. выводим значение третьей строки (то есть индекс 2)


Console.Write("Введи число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 99)
{
  string numberText = Convert.ToString(number);
  Console.WriteLine("третья цифра " + numberText[2]);
}
else {
  Console.WriteLine("третьей цифры нет");
}


