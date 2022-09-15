// Задача 1: Задайте двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7
//Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int m = InputNumbers("Введите количество строк: ");
int n = InputNumbers("Введите количество столбцов: ");
int range = InputNumbers("Введите диапазон: от 1 до ");

int[,] array = new int[m, n]; // объявляем 2х мерный массив
NewArray(array);  // массив в функцию newarray
PrintArray(array);

int minSum = 0; //заводим переменную с минимальной суммой
int sum = SumElments(array, 0); // нужно передать в переменную с максимальной то что вычислит фукция
for (int i = 1; i < array.GetLength(0); i++)
{
  int temp = SumElments(array, i);
  if (sum > temp)
  {
    sum = temp;
    minSum = i;
  }
}

Console.WriteLine($"\n{minSum+1} - строкa с наименьшей суммой ({sum}) элементов "); // выводим на экран мин сумм


int SumElments(int[,] array, int i) // Необходимо создать фукцию которая счиает сумму всех элементов циклом
{
  int sumLine = array[i,0];
  for (int j = 1; j < array.GetLength(1); j++)
  {
    sumLine += array[i,j];
  }
  return sumLine;
}

int InputNumbers(string input) // создадим метод который будет считывать с клавиатуры данные и возвращать
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

void NewArray(int[,] array) // Еще нужен метод который будет создавать генерировать числа в массиве
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(range);
    }
  }
}

void PrintArray (int[,] array) // И создаем массив печати на экран
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