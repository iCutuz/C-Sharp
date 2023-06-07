Console.WriteLine("Задача 60. Трёхмерный массив");

int[,,] Array = GetArray(2, 2, 2, 10, 100);
PrintArray(Array);

int[,,] GetArray(int x, int y, int z, int min, int max)
{
    int[,,] Array = new int[x, y, z];
    Random ram = new();
    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            for (int k = 0; k < z; k++)
            {
                Array[i, j, k] = ram.Next(min, max);
            }
        }
    }

    return Array;
}

void PrintArray(int[,,] Array)
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            for (int k = 0; k < Array.GetLength(2); k++)
            {
                Console.Write($"{Array[i, j, k]}({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
    }
}