// Напишите программу которая принимает на вход координаты (x и y) 
//причем x =/0 и y =/0  и выдает в какой плоскости из четырех в системе координат находится точка 

// while (true)
// {
// 	Task1();
// }


// void Task1()
// {
// 	int x = ReadInt("X");
// 	int y = ReadInt("Y");

// 	int quarter = GetQuarter(x, y);

// 	Console.WriteLine($"{quarter}: [{x} - {y}]");
// }


// int GetQuarter(int x, int y)
// {
// 	if (x == 0 || y == 0)
// 	{
// 		return -1;
// 	}

// 	if (x > 0 && y > 0)
// 	{
// 		return 1;
// 	}
// 	else if (x < 0 && y > 0)
// 	{
// 		return 2;
// 	}
// 	else if (x < 0 && y < 0)
// 	{
// 		return 3;
// 	}
// 	else
// 	{
// 		return 4;
// 	}
// }

// int ReadInt(string argumentName)
// {
// 	Console.Write($"Input {argumentName}: ");

// 	int number = 0;
// 	while (!int.TryParse(Console.ReadLine(), out number))
// 	{
// 		Console.WriteLine("It's not a number");
// 	}

// 	return number;
// }


// Задача 18. Напишите программу


// while (true)
// {
//     Console.Clear();
    
//     int[] coordX = new int[] {1, -1, -1, 1}; // 0 1 1 0
//     int[] coordY = new int[] {1, 1, -1, -1}; // 0 0 1 1 

//     Console.WriteLine("\nКакая четверть вас интересует?\nВвдите номер: ");

//     int number = 0;
//     while (!int.TryParse(Console.ReadLine(), out number))
//     {
//         Console.WriteLine("It's not a number.");
//     }

//     string quarterTextX;

//     if (coprdX[number - 1] > 0)
//     {
//         quarterTextX = "+Бесконечность";
//     } else quarterTextX = "-Бесконечность";

//     string quarterTextY;
   
//     if (coprdY[number - 1] > 0)
//     {
//         quarterTextY = "+Бесконечность";
//     } else quarterTextY = "-Бесконечность";
//     Console.WriteLine($"\nЧетверть {number}:\nX от {coordX[number -1]} до {quarterTextX}\nY от {coordY[number -1]} до {quarterTextY}");
//     Console.ReadKey();
//}

//(х2— х1)2 + (y2— y1)2.
//Напишите программу, которая принимает на вход координаты
// двух точек и находит расстояние между ними в 2D пространстве.
// пример  A(3,6); B(2, 1) -> 5,09
//        A(7,-5); B(1, -1) -> 7,21

// while (true)
// {
//     Point p1 = new Point(1, 2);
//     Point p2 = new Point(3, 4); 
//     Console.WriteLine(p1.GetLegth(p2));
// }

// class Point 
// {
//     public int _x; 
//     public int _y;
//     public Point(int x, int y)
//     {
//         _x = x;
//         _y = y;

//     }

//     public double GetLegth(Point p)
//     {
//         return Math.Sqrt(Math.Pow(this._x-p._x, 2) + (Math.Pow(this._y-p._y, 2)));
//     }
// }


// Задача 21.
// Console.WriteLine("Введите число:");
// int N = Convert.ToInt32(Console.Readline());
// int index = 1;

// while (index <= N)
// {
//     //int result = Convert.ToInt32(Math.Pow(index, 2));
//     int result = (int)Math.Pow(index, 2);
//     Console.WriteLine(result);
//     index++;
// }


// // Задача 3.4 Напишите программу, которая принимает на вход число N и выдаёт таблицу квадратов чисел от 1 до N
System.Console.WriteLine("Введите число");
int.TryParse(Console.ReadLine(), out int a);
int b = 1;
while(b <= a)
{
    System.Console.WriteLine(Math.Pow(b, 2));
    b++;
}
