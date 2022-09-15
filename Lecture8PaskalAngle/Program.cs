// ДЗ к лекции 8 треугольник паскаля

int n = InputRows("Введите количество строк : ");

double[,] pascalAngle = new double[n + 1, 2 * n + 1];

FullPascalAngle(pascalAngle);

Console.WriteLine();
PrintArray(pascalAngle);

TransPascalAngle(pascalAngle);

Console.WriteLine();
PrintArray(pascalAngle);

void TransPascalAngle(double[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    int count = 0;
    for (int j = array.GetLength(1) - 1; j >= 0; j--)
    {
      if (array[i, j] != 0)
      {
        array[i, array.GetLength(1) / 2 + j - count] = array[i, j];
        array[i, j] = 0;
        count++;
      }
    }
  }
  array[array.GetLength(0) - 1, 0] = 1;
}

void FullPascalAngle(double[,] pascalAngle)
{
  for (int k = 0; k < pascalAngle.GetLength(0); k++)
  {
    pascalAngle[k, 0] = 1;
  }
  for (int i = 1; i < pascalAngle.GetLength(0); i++)
  {
    for (int j = 1; j < i + 1; j++)
    {
      pascalAngle[i, j] = pascalAngle[i - 1, j] + pascalAngle[i - 1, j - 1];
    }
  }
}
int InputRows(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

void PrintArray(double[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (array[i, j] != 0)
      {
          Console.Write($"{array[i, j]} ");
      }
      else Console.Write("  ");
    }
    Console.WriteLine();
  }
}

