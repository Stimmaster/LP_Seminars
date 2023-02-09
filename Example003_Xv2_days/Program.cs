//________________________________________________________________________________________________
// ++++++++++++++++++++++++++++++++++++++++++++++Задача №2++++++++++++++++++++++++++++++++++++++++ 
//________________________________________________________________________________________________

// Напиши программу, которая на входе принимает 2 числа и проверяет, является ли первое квадратом второго числа
//Пример:
// a = 25, b = 5 -> да
// a = 2, b = 10 -> нет
// a = 9, b = 3 -> да
// a = -3, b = 9 -> да

//*************************************Решение: Вариант 1. (с Convert.ToInt32 и if & else)*****************************************
// Console.WriteLine("Введите первое число");
// int i = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите второе число");
// int j = Convert.ToInt32(Console.ReadLine());

// int sum = (int)Math.Pow(j, 2);
// if (sum == i) Console.WriteLine("Да,  первое число является квадратом второго");
// else Console.WriteLine("Нет,  первое число не является квадратом второго"); 


//***********************Решение: Вариант 2 (с switch, case и Math.Sqrt). (Можно доработать задачу с days)*******************
 bool isWork = true;

 while (isWork) 
 {
  Console.Write("Enter a number of task");
 
    if (int.TryParse(Console.ReadLine(), out int i));
    {
     switch (i)
     {
         case 1:
        {
             int a = int.Parse(Console.ReadLine());
             int b = int.Parse(Console.ReadLine());
              if (b == Math.Sqrt(a))
             {
                 Console.WriteLine("Yes");
             }
            else Console.WriteLine("No");
            break;
        }
        case 2:
        {
            int a = int.Parse(Console.ReadLine());
             switch (a)
            {
                 case 1:
                 {
                     Console.WriteLine("Mondey");
                     break;
                 }
                 default:
                 break;
             }
             break;
         }
         case - 1: isWork = false; break;
     }
    }
} 


//*********************************Решение: Вариант 3. (с простым умножением)*****************************************
// int numberA = 25;
// int numberB = 5;
// Console.WriteLine("numberA = 25? numberB = 5");
// Console.WriteLine(numberA * numberB);
// if (numberB * numberB == numberA)
// {
//     Console.WriteLine("Да");
// }
// else
// {
//  Console.WriteLine("Нет");
// }


//________________________________________________________________________________________________________
// ++++++++++++++++++++++++++++++++++++++++++++++++Задача №3+++++++++++++++++++++++++++++++++++++++++++++ 
//________________________________________________________________________________________________________

// 2. Напиши программу, которая будет выдавать название дня недели по заданному номеру
//Пример: 
//3 -> Среда
// 5 -> Пятница

//****************************************Решение: Вариант 1.(c string массивом days )********************************************
// String[] days = new String[] {"Monday", "Tuesday", "Wendseday", "Thursday", "Friday", "Saturday", "Sunday"};
// Console.WriteLine ("Введите номер дня недели ");
// int day = int.Parse(Console.ReadLine());
// Console.WriteLine(days[day - 1]);
    
    
//****************************************Решение: Вариант 2.(c switch и case)********************************************
// Console.WriteLine("Введите номер дня недели ");
// if (int.TryParse(Console.ReadLine(), out int a))
// {
//  switch(a)
//  {
//     case 1:
//     Console.WriteLine("Понедельник");
//     break;
    
//     case 2:
//     Console.WriteLine("Вторник");
//     break;

//     case 3:
//     Console.WriteLine("Среда");
//     break;

//     case 4:
//     Console.WriteLine("Четверг");
//     break;

//     case 5:
//     Console.WriteLine("Пятница");
//     break;

//     case 6:
//     Console.WriteLine("Суббота");
//     break;

//     case 7:
//     Console.WriteLine("Восскресенье");
//     break;

//  default:
//  Console.WriteLine("Нет такого дня недели");   
//  break;
// }}


//****************************************Решение: Вариант 3.(c if и else)********************************************

// Console.WriteLine("Введите номер дня недели ");
// int.TryParse(Console.ReadLine(), out int a);

// if (a == 1) Console.WriteLine("Понедельник");
// else if (a == 2) Console.WriteLine("Вторник");
// else if (a == 3) Console.WriteLine("Среда");
// else if (a == 4) Console.WriteLine("Четверг");
// else if (a == 5) Console.WriteLine("Пятница");
// else if (a == 6) Console.WriteLine("Суббота");
// else if (a == 7) Console.WriteLine("Восскресенье");

// else Console.WriteLine("Нет такого дня недели");
