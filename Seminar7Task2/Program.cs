// Задача 2. Напишите программу, которая на вход принимает позиции (две) элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.Write("Введите число строк в массиве: m = ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число столбцов в массиве: n = ");
int n = Convert.ToInt32(Console.ReadLine());
int i = 0;
int j = 0;
int[,] nums = new int[m, n];
Random ran = new Random();
for (i = 0; i < m; i++)
{
    for (j = 0; j < n; j++)
    {
        nums[i,j] = ran.Next(1, 10);
        Console.Write(nums[i, j] + " ");
    }
    Console.WriteLine();
}

Console.Write("Введите индекс строки элемента в массиве: i = ");
i = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите индекс столбца элемента в массиве: j = ");
j = Convert.ToInt32(Console.ReadLine());

if ((i >= 0) && (i < m) && (j >= 0) && (j < n))
{
    Console.Write("[" + i + ", " + j + "] == " + nums[i, j]);
}
else
{
    Console.Write("nums[" + i + ", " + j + "] - такого числа в массиве нет");
}