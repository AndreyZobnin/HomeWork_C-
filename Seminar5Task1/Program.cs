// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
Console.WriteLine("Введите количество чисел в массиве: "); // приглашение
int N = Convert.ToInt32(Console.ReadLine()); // ковертируем
int[] arr = new int [N]; // создаем массив
int count = 0; // создаем переменную - контейнер
for (int i = 0; i < N; i++) // создаем цикл
{
    arr[i] = new Random().Next (100, 2000); // запускаем генератор случайных чисел
    Console.Write(arr[i] + ", "); // выводим на экран
        if (arr[i] % 2 == 0) // вычисляем = 0 или нет
        {
            count++; // наполняем переменную
        }
}
Console.WriteLine ("Числа:" + count); // вывод переменной