//Напишите программу вычисления функции Аккермана с помощью
//рекурсии. Даны два неотрицательных числа m и n.

Console.WriteLine("Введите начальное число M:");
int numbM = int.Parse(Console.ReadLine());

Console.WriteLine("Введите начальное число N:");
int numbN = int.Parse(Console.ReadLine());

int AckermanFunc (int numbM, int numbN)  ///Метод вычисления функции Аккермана:
{
    if (numbM == 0) return numbN + 1;
    if (numbM != 0 && numbN == 0) return AckermanFunc(numbM - 1, 1);
    if (numbM > 0 && numbN > 0) return AckermanFunc(numbM - 1, AckermanFunc(numbM, numbN - 1));
return AckermanFunc(numbM, numbN);
}

Console.WriteLine($"Функция Аккермана для чисел ({numbM},{numbN}) = {AckermanFunc(numbM, numbN)}");