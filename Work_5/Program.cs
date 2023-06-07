// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
Console.Clear();
int m = Read("Введите количество строк: ", "Задача 47. Задайте двумерный массив размером m * n, заполненный случайными вещественными числами.");
int n = Read("Введите количество столбцов: ", "");
Console.WriteLine();

double[,] array = GetNewArray(m, n, -10, 10);
PrintArray(array);

int Read(string msg, string task)
{
    Console.WriteLine(task);
    Console.WriteLine(msg);
    int read = int.Parse(Console.ReadLine());
    return read;
}

double[,] GetNewArray(int m, int n, int minValue, int maxValue)
{
    Random rdm = new();
    double[,] newArray = new double[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            newArray[i, j] = Math.Round(rdm.Next(minValue, maxValue) + rdm.NextDouble(), 2);
        }
    }

    return newArray;
}

void PrintArray(double[,] array)
{
    Console.WriteLine($"Массив из {m} строк и {n} столбцов:");
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($" | {array[i, j]}");
        }
        Console.WriteLine();
    }
}

// Задача 50. Напишите программу, которая на вход принимает элемент в двумерном массиве,
// и возвращает его индексы первого найденого числа или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
Console.ReadLine();
Console.Clear();

int[,] matrix = newMatr(5, 5, 0, 10);

int[,] newMatr(int rows, int collumns, int minValue, int maxValue)
{
    Random rmd = new();
    int[,] result = new int[rows, collumns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < collumns; j++)
        {
            result[i, j] = rmd.Next(minValue, maxValue);
        }
    }
    return result;
}

void PrintMatr(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($" | {array[i, j]}");
        }
        Console.WriteLine();
    }
}

PrintMatr(matrix);
int value = Read("Введите нужное значение:", "Задача 50. Определить индексы нужного элемента");
FindValue(value, matrix);

void FindValue(int value, int[,] matrix)
{
    for (int row = 0; row < matrix.GetLength(0); row++)
    {
        for (int coll = 0; coll < matrix.GetLength(1); coll++)
        {
            if (matrix[row, coll] == value)
            {
                Console.WriteLine($"Значение {value} имеет индекс [{row}, {coll}]");
                break;
            }
        }
    }
}

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
Console.ReadLine();
Console.Clear();
Console.WriteLine("Задача 52. Нахождение ср. арифметического элементов в столбцах");

int[,] massive = newMatr(5, 5, 0, 10);
PrintMatr(massive);
Mean(massive);

double Mean(int[,] massive)
{
    double result = 0;

    for (int i = 0; i < massive.GetLength(0); i++)
    {
        result = 0;

        for (int j = 0; j < massive.GetLength(1); j++)
        {
            result = result + massive[j, i];
        }
        result = Math.Round((result / massive.GetLength(1)), 2);
        Console.WriteLine($"Сред. арифм. {i+1}-го столбца =  {result}");
    }
    return result;
}