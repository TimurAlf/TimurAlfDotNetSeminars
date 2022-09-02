// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


double[,] GetArray(int n, int m)
{
    double[,] arr = new double[n, m];

    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            arr[i, j] = new Random().NextDouble() * (100 - 0) + 0;
        }
    }
    return arr;
}

void PrintArray(double[,] arr)
{
    int rows = arr.GetLength(0), cols = arr.GetLength(1);

    for (int row = 0; row < rows; row++)
    {
        for (int col = 0; col < cols; col++)
        {
            System.Console.Write($"{arr[row, col], 3}");
        }
        System.Console.WriteLine();
    }
}

double[,] array = GetArray(3, 4);
PrintArray(array);
