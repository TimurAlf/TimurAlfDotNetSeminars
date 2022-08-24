// вывод двумерного массива страка столбец, потом столбец строка.
// 00 11 22
// 33 44 55
// 66 77 88
// 00 11 22 33 44 55 66 77 88
// 00 33 66 11 44 77 22 55 88

int[,] CreateArray(int row, int col)
{
    return new int[row, col];
}

void Fill(int[,] array)
{
    int rows = array.GetLength(0), cols = array.GetLength(1);

    for (int row = 0; row < rows; row++)
    {
        for (int col = 0; col < cols; col++)
        {
            array[row, col] = Random.Shared.Next(10);
        }
    }
}

void PrintRowCol(int[,] array)
{
    int rows = array.GetLength(0), cols = array.GetLength(1);

    for (int row = 0; row < rows; row++)
    {
        for (int col = 0; col < cols; col++)
        {
            System.Console.Write($"{array[row, col],3}");
        }
        //System.Console.WriteLine();
    }
}


void PrintColRow(int[,] array)
{
    int rows = array.GetLength(0), cols = array.GetLength(1);


    for (int col = 0; col < cols; col++)
    {
        for (int row = 0; row < rows; row++)
        {
            System.Console.Write($"{array[row, col],3}");
        }
        //System.Console.WriteLine();
    }

}

int[,] table = CreateArray(3,4);
Fill(table);
System.Console.WriteLine();
PrintColRow(table);
System.Console.WriteLine();
PrintRowCol(table);

// Показать двумерный массив размером m×n заполненный целыми числами

// Показать двумерный массив размером m×n заполненный вещественными числами

// В двумерном массиве n×k заменить четные элементы на противоположные (поменять знак) (-)

// Задать двумерный массив следующим правилом: Aₘₙ = m+n

// В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты

// В двумерном массиве показать позиции числа, заданного пользователем или указать, что такого элемента нет

// В матрице чисел найти сумму элементов главной диагонали