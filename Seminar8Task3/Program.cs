// Задача 3. 
//Сформируйте двухмерный массив из неповторяющихся двузначных чисел (размер массива не более 50 элементов). Напишите программу, которая будет построчно выводить массив.
	// Вариант создания функции:
	// Проверить число на присутствие в массиве (bool Contains(int[,] arr, int value){...} )
	// Пример:
	// Массив размером 3 x 3
	// 10 11 55
	// 33 41 23
	// 17 28 34
	
	Console.Write("Введите число строк в массиве: = ");
	int x = Convert.ToInt32(Console.ReadLine());
	int tmp = 50 / x;
	Console.Write("Введите число столбцов в массиве от 1 до " + tmp + ": n = ");
	int n = Convert.ToInt32(Console.ReadLine());
		
		
	int[,] num = new int[x, n];
	Random rand = new Random();
	int temp = 1;
	for (int i = 0; i < x; i++)
	{
	    for (int j = 0; j < n; j++)
	    {
	        temp = rand.Next(10, 100);
	        do
	        {
	            temp = rand.Next(10, 100);
	        }
	        while (Contains(num, temp));
	        num[i, j] = temp;
	        Console.Write(num[i, j] + " ");
	    }
	    Console.WriteLine();
	}

bool Contains(int[,] arr, int value)
	{
	    for (int i = 0; i < arr.GetLength(0); i++)
	    {
	        for (int j = 0; j < arr.GetLength(1); j++)
	        {
	            if (value == arr[i, j])
	            {
	                return true;
	            }
	        }
	    }
	    return false;
	}