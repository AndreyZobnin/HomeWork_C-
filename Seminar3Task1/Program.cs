//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//Число хранить в типе данных int, решать с помощью арифметических операций (не рассматривая число как тип данных string)
System.Console.WriteLine();
System.Console.Write("Введите целое число:   ");
string number = Console.ReadLine();
int length = number.Length;
string txtToCheck = number.Replace(" ","");  /// для проверки текста на палиндром

bool IsPalindrome()
{
    for (int i = 0; i < length / 2; i++)
        while (number[i] == number[length - 1])
        {
            return true;
        }
    return false;
}

if (IsPalindrome()) System.Console.WriteLine($"Введный текст/число - {number} - является палиндромом");
else System.Console.WriteLine($"Число {number} не является палиндромом");
System.Console.WriteLine();
