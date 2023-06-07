Console.Clear();

// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

// M = 1 N = 5 -> "5, 4, 3, 2, 1"
// M = 1 N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
Console.WriteLine("*Задача 64 - вывод чисел от M до N*");
int M = SetNum("Введите число M: ");
int N = SetNum("Введите число N: ");
Console.WriteLine();
NumbersFromMToN(M, N);

int SetNum(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine());
    return num;
}

void NumbersFromMToN(int Min, int Max)
{
    if (Min < Max)
    {
        Console.Write($"{Min}, ");
        NumbersFromMToN(Min + 1, Max);
    }
    else
    {
        Console.WriteLine($"{Max}.");
    }
}

End("Перейти к следующей задаче - Enter");

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
Console.WriteLine("*Задача 66 - сумма чисел от M до N*");
M = SetNum("Введите число M: ");
N = SetNum("Введите число N: ");
Console.WriteLine($"Сумма чисел от {M} до {N} = {Sum(M, N)}");

int Sum(int Min, int Max)
{
    int result = 0;
    result = summa(Min, Max);

        int summa(int Min, int Max)
        {
            if (Min <= Max) { result += Min; summa(Min + 1, Max); };
            return result;
        }

    return result;
}

End("Перейти к следующей задаче - Enter");

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
Console.WriteLine("*Задача 68 - вычисление функции Аккермана A(m,n)*");
M = SetNum("Введите число M: ");
N = SetNum("Введите число N: ");

Console.Write($"Функция Аккермана = {Ack(M, N)} ");

int Ack(int m, int n)
{
  if (m == 0) return n + 1;
  else if (n == 0) return Ack(m - 1, 1);
  else return Ack(m - 1, Ack(m, n - 1));
}

void End(string msg)
{
    Console.WriteLine();
    Console.WriteLine(msg);
    Console.ReadLine();
    Console.Clear();
}