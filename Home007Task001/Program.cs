double[,] CreateTriangle(double row)
{
  double[,] triangle = new double[Convert.ToInt32(row), Convert.ToInt32(row)];
  for (int i = 0; i < Convert.ToInt32(row); i++)
  {
    triangle[i, 0] = 1;
    triangle[i, i] = 1;
  }

  for (int i = 2; i < Convert.ToInt32(row); i++)
  {
    for (int j = 1; j <= i; j++)
    {
      triangle[i, j] =
      triangle[i - 1, j - 1] + triangle[i - 1, j];
    }
  }
  return triangle;
}

void PrintTriangle(double[,] triangle)
{
  double row = triangle.GetLength(0);
  for (int i = 0; i < Convert.ToInt32(row); i++)
  {
    for (int j = 0; j < Convert.ToInt32(row); j++)
    {
      if (triangle[i, j] != 0 && triangle[i, j] % 2 == 1)
        Console.Write($"*");
        else Console.Write($" ");
    }
    Console.WriteLine();
  }
}

double[] GetKoeff(double[,] tr, double pow)
{
  double[] row = new double[Convert.ToInt32(pow + 1)];
  for (int i = 0; i <= Convert.ToInt32(pow); i++)
  {
    row[i] = tr[Convert.ToInt32(pow), i];
  }
  return row;
}

double[,] tr = CreateTriangle(12
0);
PrintTriangle(tr);
double[] koeff = GetKoeff(tr, 5);

System.Console.WriteLine(String.Join(' ', koeff));

System.Console.WriteLine(koeff.Length);

for (int i = 0; i < koeff.Length; i++)
{
    if (i == 0 && koeff[i] == 1)  Console.Write($"a^{koeff.Length - 1 - i} + ");
    else if ((koeff.Length - 1 - i) == 0 && koeff[i] == 1) Console.Write($"b^{i} ");
        else if (i==1) Console.Write($"{koeff[i]}*a^{koeff.Length - 1 - i}*b + ");
            else if ((koeff.Length - 1 - i) == 1) Console.Write($"{koeff[i]}*a*b^{i} + ");
                else Console.Write($"{koeff[i]}*a^{koeff.Length - 1 - i}*b^{i} + ");
}