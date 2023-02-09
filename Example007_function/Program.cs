// 1.
// Console.WriteLine(CalculateSumToN(ReadInt("number")));

// 2. Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе
//Console.WriteLine(CalculateNumbers(ReadInt("number")));

// 3. Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N
//Console.WriteLine(GetFactorial(ReadInt("number")));

// 4. Напишите программу, которая наполняет массив из 8 элементов случайными числами от 0 до 1

// int[] array = new int[8];

// FillArray(array);
// PrintArray(array);


// int ReadInt(string argument)
// {
//   Console.Write($"Input {argument} ");
//   int number;

//   while (!int.TryParse(Console.ReadLine(), out number))
//   {
//     Console.WriteLine("It's not a int");
//   }

//   return number;
// }

// int CalculateSumToN(int number)
// {
//   int sum = 0;

//   for (int i = 0; i <= number; i++)
//   {
//     sum += i;
//   }

//   return sum;
// }

// 3. Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе

// int CalculateNumbers(int number)
// {
//   int count = 0;

//   while (number > 0) 
//   {
//     number /= 10;
//     count++;
//   }

//   return count;
// }

// // Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N

// int GetFactorial(int number)
// {
//   int factorial = 1;

//   for (int i = 1; i <= number; i++) 
//   { 
//     factorial *= i;
//   }

//   return factorial;
// }

// // Напишите программу, которая 

void FillArray(int[] arr)
{
  Random random = new Random();

  for (int i = 0; i < arr.Length;i++)
  {
    arr[i] = random.Next(0, 2);
  }
}

void PrintArray(int[] arr)
{
  for (int i = 0; i < arr.Length; i++) 
  {
    Console.Write($"{arr[i]}");
  }
}
