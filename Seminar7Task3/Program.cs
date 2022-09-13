// Задача 3. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
	// Например, задан массив:
	// 1 4 7 2
	// 5 9 2 3
	// 8 4 2 4
	// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
	Console.Write("Введите число строк в массиве: m = ");
	int m = Convert.ToInt32(Console.ReadLine());
	Console.Write("Введите число столбцов в массиве: n = ");
	int n = Convert.ToInt32(Console.ReadLine());
	int i = 0;
	int j = 0;
	double[,] nums = new double[m, n];
	Random ran = new Random();
	for (i = 0; i < m; i++)
	{
	    for (j = 0; j < n; j++)
	    {
	        nums[i, j] = ran.Next(1, 10);
	        Console.Write(nums[i, j] + " ");
	    }
	    Console.WriteLine();
	}
	
	double avg = 0;
	double tmp = 0;
	Console.Write("Среднее арифметическое: ");
	
	for (j = 0; j < n; j++)
	{
	    for (i = 0; i < m; i++)
	    {
	        tmp = tmp + nums[i, j];
	    }
	    avg = Math.Round(tmp / m, 1);
	    Console.Write(avg + "; ");
	    avg = 0;
	    tmp = 0;
	}



int m = 5; int n = 4;  int[,] arr = new int[m, n]; Random rand = new Random(); int[] countArray = new int[10];  for (int i = 0; i < arr.GetLength(0); i++) {     for (int j = 0; j < arr.GetLength(1); j++)     {         arr[i, j] = rand.Next(0, 10);         countArray[arr[i, j]] += 1;         Console.Write($"{arr[i, j]} \t");     }     Console.WriteLine(); }  for (int i = 0; i < 10; i++) {     if (countArray[i] != 0)     {         Console.WriteLine($"{i}: {countArray[i]}");     } }