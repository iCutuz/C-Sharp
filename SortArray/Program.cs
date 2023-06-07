int N = ConsoleInput("Введите кол-во строк");
int M = ConsoleInput("Введите кол-во коллон");
int[,] Array = RandomArray(N, M);
Console.Clear();
PrintArray(Array, "Сгенерированный массив:");
SortArray(Array);
PrintArray(Array, "Сортированный массив:");

int ConsoleInput(string msg = "Ввод")
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine()!);
}

int[,] RandomArray(int N, int M)
{
    int[,] result = new int[N, M];
    Random rnd = new Random();

    for (int i = 0; i < N; i++)
    {
        for (int j = 0; j < M; j++)
        {
            result[i, j] = rnd.Next(0, 100);
        }
    }

    return result;
}

void PrintArray(int[,] Array, string msg = "")
{
    Console.WriteLine(msg);
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            Console.Write($"{Array[i, j]}, ");
        }
        Console.WriteLine();
    }
}

int[,] SortArray(int[,] Array)
{
    int temp = 0;
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            for (int k = 0; k < Array.GetLength(1) - 1; k++)
            {
                if (Array[i, k] < Array[i, k + 1])
                {
                    temp = Array[i, k + 1];
                    Array[i, k + 1] = Array[i, k];
                    Array[i, k] = temp;
                }
            }
        }
    }
    return Array;
}