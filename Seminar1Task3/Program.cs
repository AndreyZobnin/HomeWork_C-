﻿//Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

//4 -> да
//-3 -> нет
//7 -> нет
int a;
Console.Write("введите число: ");
a =  Convert.ToInt32(Console.ReadLine());
if (a % 2==1) //формула определение четности числа Если ... и т.д.
    {
    Console.WriteLine("число нечетное");
    }
    else
    {
    Console.WriteLine("Число четное");
    }