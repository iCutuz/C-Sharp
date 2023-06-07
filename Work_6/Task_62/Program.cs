Console.WriteLine("Задача 62. Напишите программу, которая заполнит спирально массив . Размер вводит юзер");
Console.WriteLine("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество коллонок: ");
int collumns = int.Parse(Console.ReadLine());

int[,] Array = NewArray(rows, collumns);
PrintArray(Array);

int[,] NewArray(int rows, int collumns)
{
    int[,] array = new int[rows, collumns];
    int num = 1;
    int i = 0;
    int j = 0;

    while (num <= rows * collumns)
    {
        array[i, j] = num;
        if (i <= j + 1 && i + j < collumns - 1)
            ++j;
        else if (i < j && i + j >= rows - 1)
            ++i;
        else if (i >= j && i + j > collumns - 1)
            --j;
        else
            --i;
        ++num;
    }

    return array;
}

void PrintArray(int[,] Array)
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            Console.Write($"{Array[i, j]} ");
        }
        Console.WriteLine();
    }
}