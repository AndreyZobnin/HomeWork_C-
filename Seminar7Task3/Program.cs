// Задача 3. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
Console.Write("Введите число строк в массиве: m = ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число столбцов в массиве: n = ");
int n = Convert.ToInt32(Console.ReadLine());
int i = 0;
int j = 0;
double[,] nums = new double[m, n];
Random ran = new Random();
for (i = 0; i < m; i++)
{
    for (j = 0; j < n; j++)
    {
        nums[i, j] = ran.Next(1, 10);
        Console.Write(nums[i, j] + " ");
    }
    Console.WriteLine();
}

double avg = 0;
double tmp = 0;
Console.Write("Среднее арифметическое каждого столбца: ");

for (j = 0; j < n; j++)
{
    for (i = 0; i < m; i++)
    {
        tmp = tmp + nums[i, j];
    }
    avg = Math.Round(tmp / m, 1);
    Console.Write(avg + "; ");
    avg = 0; 
    tmp = 0;
}