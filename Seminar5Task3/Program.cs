//Задайте массив натуральных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 7
Console.Write("Какое будет количество чисел массива?"); //Приглашение вопрос
int N = Convert.ToInt32(Console.ReadLine()); // Конвертируем
int [] massiv = new int [N]; // создаем массив количество берем из консоли N
for (int i = 0; i < N; i++)
{
    Console.WriteLine("Введи индексы c 0" );
    massiv[i] = Convert.ToInt32(Console.ReadLine());

    // massiv[i] = new Random().Next(N);

}
int Minimum (int[] massiv) { //создаем метод который берет значения из массива
    int minimum = massiv [0]; // создаем и переменная будет равна индексу массива
    for (int j = 1; j < N; j++) //цикл итерация с J
    {
        if (massiv[j] < minimum) { // условие сравниваем
            minimum = massiv[j]; // вычисляем и записываем в переменную
        }
    }
    return minimum; // возвращаем значение
}
int Maximum (int[] massiv) { //тоже самое только используем i и знак > больше
    int maximum = massiv [0];
    for (int i = 1; i < N; i++)
    {
        if (massiv[i] > maximum) 
        {
            maximum = massiv[i];
        }
    }
    return maximum;
}
int max = Maximum(massiv);
int min = Minimum(massiv);
int result  = max - min;
Console.WriteLine("разница "  + result);