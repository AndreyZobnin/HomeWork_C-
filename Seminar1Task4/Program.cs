//4 дз вывод всех положительных чисел до значения вводного числа
Console.Write("введите число: "); //приглашение ввести число
int num = Convert.ToInt32(Console.ReadLine()); // конвертация
int result = 1; //переменная =1
while (result < num) //цикл пока 1 меньше числа
   {
   Console.WriteLine(result + 1); //положить 1 в цикл
   result += 2; //добавька еще 2 ).
   }  
