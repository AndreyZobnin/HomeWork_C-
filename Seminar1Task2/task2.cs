//2ДЗ сравнение 3 чисел
int a, b, x; //вводим 1 переменную
//int b; // вводим 2 переменную
//int x;// вводим 3 переменную
Console.WriteLine("Введите первое число : ");
a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число : ");
b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число : ");
x = Convert.ToInt32(Console.ReadLine());
int max = 0; // вводим переменную max и присваиваем ей значение 0
if (a > b ) //сравниваем
   {
    max = a; // записываем в max
   }
if (b > a) // сравниваем 
   {
      max = b; // записываем в max
   }
if (x > max)
    {
    max = x;
    }

      Console.WriteLine("Наибольшее число: {0} ", max); // выводим max 