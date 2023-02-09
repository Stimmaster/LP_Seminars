﻿
//Task_1();
//Task_2();
Task_3();

void Task_1()
{
	int a = ReadInt("First Number");
	int b = ReadInt("Second Number");

	PrintMoreFromTwo(a, b);
}

void Task_2()
{
	int[] array = new int[] { ReadInt("First Number"), ReadInt("Second Number"), ReadInt("Third Number") };

	PrintMoreFromArray(array);
}

// string s = CR;
// char[] array = s.ToCharArray();
// int.TryParse(array[2].ToString(), out int)

void Task_3()
{
	int digital = GetThirdDigital(ReadInt("Number"));

	if (digital > 0)
	{
		Console.WriteLine(digital);
	}
	else
	{
		Console.WriteLine("None");
	}
}

int ReadInt(string argument)
{
	Console.Write($"Input {argument}: ");
	int number;

	while (!int.TryParse(Console.ReadLine(), out number))
	{
		Console.WriteLine("Error! Try again.");
	}

	return number;
}

void PrintMoreFromTwo(int firstNumber, int secondNumber)
{
	if (firstNumber > secondNumber)
	{
		Console.WriteLine($"{firstNumber} > {secondNumber}");
	}
	else
	{
		Console.WriteLine($"{secondNumber} > {firstNumber}");

	}
}

void PrintMoreFromThree(int firstNumber, int secondNumber, int thirdNumber)
{
	int max = firstNumber;

	if (secondNumber > max)
	{
		max = secondNumber;
	}

	if (thirdNumber > max)
	{
		max = thirdNumber;
	}

	Console.WriteLine($"The bigger number is {max}");
}

void PrintMoreFromArray(int[] array)
{
	int max = array[0];

	for (int i = 1; i < array.Length; i++)
	{
		if (max < array[i])
		{
			max = array[i];
		}
	}

	Console.WriteLine($"The bigger number is {max}");
}

int GetThirdDigital(int number)
{
	if (number < 100)// 99 == 99 // 99 > 99
	{
		return -1;
	}

	while (number / 10 >= 100)
	{
		number /= 10;
	}

	return number % 10;
}