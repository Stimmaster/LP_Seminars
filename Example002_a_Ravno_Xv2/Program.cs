Console.WriteLine("Введите первое число");
int i = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число");
int j = Convert.ToInt32(Console.ReadLine());

int sum = (int)Math.Pow(i, 2);
if (sum == j) 
{
   Console.WriteLine("Да,  первое число является квадратом второго");
}
else 
{
Console.WriteLine("Нет,  первое число не является квадратом второго"); 
}