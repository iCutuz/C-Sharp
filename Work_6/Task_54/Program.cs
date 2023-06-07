// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

Console.WriteLine("*Задача 54. Сортировка сгенерированного массива*");
int rows = GetNumber("Введите количество строк");
int collumns = GetNumber("Введите количество коллон");
int minValue = GetNumber("Введите минимальное значение");
int maxValue = GetNumber("Введите максимальное значение") + 1;
int[,] Array = RandomArray(rows, collumns, minValue, maxValue);
PrintArray(Array, "Массив сгенерирован");
Console.WriteLine();
PrintArray(SortArray(Array), "Массив отсортирован");

int GetNumber(string msg = " ")
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine()!);
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

int[,] SortArray(int[,] Array)
{
    int temp;
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            for (int k = j + 1; k < Array.GetLength(1); k++)
            {
                if (Array[i, j] < Array[i, k])
                {
                    temp = Array[i, j];
                    Array[i, j] = Array[i, k];
                    Array[i, k] = temp;
                }
            }
        }
    }

    return Array;
}