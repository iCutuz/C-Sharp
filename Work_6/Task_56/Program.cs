// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку
// с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
Console.WriteLine("*Задача 56. Нахождение строки, с наименьшей суммой элементов*");

int rows = GetNumber("Введите количество строк");
int collumns = GetNumber("Введите количество коллон");
int minValue = GetNumber("Введите минимальное значение");
int maxValue = GetNumber("Введите максимальное значение") + 1;
int[,] Array = RandomArray(rows, collumns, minValue, maxValue);
PrintArray(Array, "Массив сгенерирован: ");
Console.WriteLine();
Console.WriteLine($"Строка с наименьшей суммой элементов: {FindMinRow() + 1}-ая строка");

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

void PrintArray(int[,] Array, string text=" ")
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

int FindMinRow()
{
    int minRow = 0;
    for (int i = 0; i < Array.GetLength(0) - 1; i++)
    {
        if (sumRow(i + 1) <= sumRow(minRow))
        {
            minRow = i + 1;
        }
    }
    return minRow;
}

int sumRow(int n)
{
    int sum = 0;
    for (int j = 0; j < Array.GetLength(1); j++)
    {
        sum += Array[n, j];
    }
    return sum;
}