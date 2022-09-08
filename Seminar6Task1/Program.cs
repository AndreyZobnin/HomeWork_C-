//Программа запрашивает натуральное число M, пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
Console.Write("Введи количество чисел : ");
int m = Convert.ToInt32(Console.ReadLine());
int[] massiv = new int[m]; //создаем массив принимает значения от пользователя с клавиатуры

void Input(int m) // метод считает колво введенных чисел в массив
{
for (int i = 0; i < m; i++)
  {
    Console.Write($"Введи {i+1} число: ");
    massiv[i] = Convert.ToInt32(Console.ReadLine());
  }
}


int Sravnenie(int[] massiv) // функция которая перебирает массив на положительные числа и добавляет их кол-во в переменную возвращая ее.
{
  int count = 0;
  for (int i = 0; i < massiv.Length; i++)
  {
    if(massiv[i] > 0 ) count ++; 
  }
  return count;
}

Input(m); //Нужна для метода

Console.WriteLine($"Введено чисел больше 0 =  {Sravnenie(massiv)} ");
