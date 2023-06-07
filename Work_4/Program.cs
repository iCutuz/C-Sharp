Console.Clear();
// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
Console.Clear();
Console.WriteLine();
Console.WriteLine("*Задача 34. Нахождение кол-ва четных и нечетных чисел*");
int minValue = 100;
int maxValue = 1000;
int size = 5;

int[] Nums = GetNums(size, minValue, maxValue);
Console.WriteLine($"Массив: {string.Join(" | ", Nums)}");

int[] GetNums(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
        result[i] = new Random().Next(minValue, maxValue);

    return result;
}

int Even = 0;
int notEven = 0;

(int Even, int notEven) GetEven(int[] Array)
{
    for (int i = 0; i < size; i++)
    {
        if (Array[i] % 2 == 0)
        {
            Even++;
        }
        else
        {
            notEven++;
        }
    }

    return (Even, notEven);
}
GetEven(Nums);
Console.WriteLine($"Количество чётных чисел = {Even}");
Console.WriteLine($"Количество нечётных чисел = {notEven}");

// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
Console.WriteLine();
Console.WriteLine("*Задача 36. Нахождение суммы чисел, стоящих на нечётных позициях*");

int[] Massive = GetMassive(-100, 100);
Console.WriteLine($"Массив: {string.Join(" | ", Massive)}");

int[] GetMassive(int min, int max)
{
    int[] result = new int[4];

    for (int i = 0; i < result.Length; i++)
    {
        result[i] = new Random().Next(min, max);
    }

    return result;
}

int summa = 0;
int sum(int[] Massive)
{
    for (int i = 1; i < Massive.Length; i += 2)
    {
        summa = summa + Massive[i];
    }

    return summa;
}
sum(Massive);
Console.WriteLine($"Сумма чисел на нечетных позициях = {summa}");

// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.WriteLine();
Console.WriteLine("*Задача 38. Нахождение разницы между максимальным и минимальным элементами массива*");

double[] Numbers = newNumbers(5, 0, 999);
Console.WriteLine($"Массив: {string.Join(" | ", Numbers)}");

double[] newNumbers(int size, int minValue, int maxValue)
{
    double[] res = new double[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue) + new Random().NextDouble();
    }
    return res;
}

int max = 0;
int min = 0;

(int max, int min) FindMinMax(double[] Numbers)
{
    for (int i = 0; i < Numbers.Length; i++)
    {
        if (Numbers[i] >= Numbers[max])
        {
            max = i;
        }
        else if (Numbers[i] <= Numbers[min])
        {
            min = i;
        }
    }

    Console.WriteLine($"Максимальное число: {Numbers[max]}");
    Console.WriteLine($"Минимальное число: {Numbers[min]}");
    return (max, min);
}
FindMinMax(Numbers);

double Answer = Numbers[max] - Numbers[min];

Console.WriteLine($"Ответ: Разница между максимальным и минимальным числами = {Answer}");