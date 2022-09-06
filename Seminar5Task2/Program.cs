//Задайте одномерный массив, заполненный случайными числами. Найдите сумму четных элементов, стоящих на нечётных позициях (позиция - индекс элемента в массиве).
Console.WriteLine("Введите количетво элементов в массиве" );
int N = Convert.ToInt32(Console.ReadLine());
int [] arr = new int [N];
int countSum = 0;
for (int i = 0; i < N; i++)
{
    arr[i] = new Random().Next (0, 100);
    Console.Write(arr[i] + ", ");
    if ((i % 2 != 0) && (arr[i] % 2 == 0))
    {
        countSum = countSum + arr[i];
    }
}

Console.WriteLine("Сумма четных элементов на нечетных позициях " + countSum);