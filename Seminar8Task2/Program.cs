//Задайте две квадратные матрицы одного размера. Напишите программу, которая будет находить произведение двух матриц.
//Например, даны 2 матрицы:
//2 4 | 3 4
//3 2 | 3 3
//Результирующая матрица будет:
//18 20
//15 18
int a = InputNumbers("Введите число строк 1-й матрицы: ");
int b = InputNumbers("Введите число столбцов 1-й матрицы (и строк 2-й матрицы): ");
int p = InputNumbers("Введите число столбцов 2-й матрицы: ");
int range = InputNumbers("Введите диапазон чисел: от 1 до ");

int[,] Martrixfirst = new int[a, b];
CreateArray(Martrixfirst);
Console.WriteLine($"\nПервая матрица:");
PrintArray(Martrixfirst);

int[,] secomdMartrix = new int[b, p];
CreateArray(secomdMartrix);
Console.WriteLine($"\nВторая матрица:");
PrintArray(secomdMartrix);

int[,] resultMatrix = new int[a,p];

MultiplyMatrix(Martrixfirst, secomdMartrix, resultMatrix);
Console.WriteLine($"\n Произведение первой и второй матриц = :");
PrintArray(resultMatrix);

void MultiplyMatrix(int[,] Martrixfirst, int[,] secomdMartrix, int[,] resultMatrix)
{
  for (int i = 0; i < resultMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < Martrixfirst.GetLength(1); k++)
      {
        sum += Martrixfirst[i,k] * secomdMartrix[k,j];
      }
      resultMatrix[i,j] = sum;
    }
  }
}

int InputNumbers(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

void CreateArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(range);
    }
  }
}

void PrintArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
  }
}