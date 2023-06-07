// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

System.Console.WriteLine("№19 - Определение палиндрома");

System.Console.WriteLine("Введите пятизначное число:");
int number = int.Parse(Console.ReadLine());

int num1 = number / 10000; System.Console.WriteLine($"num1 = {num1}");
int num2 = number / 1000 %10; System.Console.WriteLine($"num2 = {num2}");
int num3 = number / 10 %10; System.Console.WriteLine($"num3 = {num3}");
int num4 = number % 10; System.Console.WriteLine($"num4 = {num4}");

if (num1 == num4 && num2 == num3)
{
    System.Console.WriteLine($"Число {number} - палиндром");
}else
{
    System.Console.WriteLine($"Число {number} - НЕ палиндром");
}

// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

System.Console.WriteLine("№21 - Нахождение координат в 3D пространстве");

System.Console.WriteLine("Введите координату X1:");
int X1 = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите координату Y1:");
int Y1 = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите координату Z1:");
int Z1 = int.Parse(Console.ReadLine());

System.Console.WriteLine("Введите координату X2:");
int X2 = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите координату Y2:");
int Y2 = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите координату Z2:");
int Z2 = int.Parse(Console.ReadLine());

double result = Math.Sqrt(Math.Pow(X2 - X1, 2) + Math.Pow(Y2 - Y1, 2) + Math.Pow(Z2 - Z1, 2));
System.Console.WriteLine($"Ответ = {result}");

// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

System.Console.WriteLine("№23 - Нахождение кубов от 1 до введённого числа");

System.Console.WriteLine("Введите число от 1 до бесконечности:");
int N = int.Parse(Console.ReadLine());

for (int i = 1; i <= N; i++)
{
    System.Console.Write($"{i*i*i}, ");
}