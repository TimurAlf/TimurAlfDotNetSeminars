// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] array = new int[,]
{
{1, 4, 7, 2},
{5, 9, 2, 3},
{8, 4, 2, 4},
};

GetArithmeticMean(array);

void GetArithmeticMean(int[,] array)
{
    int n = array.GetLength(0), m = array.GetLength(1);

    Console.WriteLine($"Cреднее арифметическое:");
    for (int i = 0; i < m; i++)
    {
        double arithmeticMean = 0;
        for (int j = 0; j < n; j++)
        {
            arithmeticMean = arithmeticMean + array[j, i];
        }
        arithmeticMean = Math.Round(arithmeticMean / n, 1);
        Console.WriteLine($"{i + 1} столбца => {arithmeticMean}");
    }
}

