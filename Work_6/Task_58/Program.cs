// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.WriteLine("*Задача 58. Нахождение произведения двух матриц*");
Console.WriteLine("Создание первой матрицы");

int rows = GetNumber("Введите количество строк");
int collumns = GetNumber("Введите количество коллон");
int minValue = GetNumber("Введите минимальное значение");
int maxValue = GetNumber("Введите максимальное значение") + 1;
int[,] Array = RandomArray(rows, collumns, minValue, maxValue);
Console.WriteLine();

Console.WriteLine("Создание второй матрицы");

int rows2 = GetNumber("Введите количество строк");
int collumns2 = GetNumber("Введите количество коллон");
int minValue2 = GetNumber("Введите минимальное значение");
int maxValue2 = GetNumber("Введите максимальное значение") + 1;
int[,] Array2 = RandomArray(rows2, collumns2, minValue2, maxValue2);
Console.Clear();

PrintArray(Array, "Матрица 1: ");
PrintArray(Array2, "Матрица 2: ");
Console.WriteLine();

int GetNumber(string msg = " ")
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine());
    return num;
}

int[,] RandomArray(int rows, int collumns, int minValue, int maxValue)
{
    int[,] RandomArray = new int[rows, collumns];
    Random rmd = new();

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < collumns; j++)
        {
            RandomArray[i, j] = rmd.Next(minValue, maxValue);
        }
    }

    return RandomArray;
}

void PrintArray(int[,] Array, string text = " ")
{
    Console.WriteLine(text);
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            Console.Write($"{Array[i, j]} ");
        }
        Console.WriteLine();
    }
}

if (collumns == rows2)
{
    int[,] Array3 = ProArray(Array, Array2);
    Console.WriteLine("Произведение матриц равно:");
    PrintArray(Array3);
}
else
{
    Console.WriteLine("Невозможно сделат ьпроизведение матриц");
}

int[,] ProArray(int[,] Array, int[,] Array2)
{
    var Array3 = new int[Array.GetLength(0), Array2.GetLength(1)];

    for (int i = 0; i < Array3.GetLength(0); i++)
    {
        for (int j = 0; j < Array3.GetLength(1); j++)
        {
            Array3[i, j] = 0;
            for (int n = 0; n < Array.GetLength(1); n++)
            {
                Array3[i, j] += Array[i, n] * Array2[n, j];
            }
        }
    }
    return Array3;
}