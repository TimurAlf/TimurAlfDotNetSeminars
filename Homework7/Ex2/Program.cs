// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, 
//что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого числа в массиве нет

int[,] array = new int[,]
{
{1, 4, 7, 2},
{5, 9, 2, 3},
{8, 4, 2, 4}
};

System.Console.WriteLine("Введите позицию элемента в массиве: ");
int n = Convert.ToInt32(Console.ReadLine());
int m = Convert.ToInt32(Console.ReadLine());

SearchPosition(array, n, m);

void SearchPosition(int[,] array, int n, int m)
{
    int rows = array.GetLength(0), cols = array.GetLength(1);

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            if (i == n && j == m) System.Console.WriteLine($"({n},{m}) элемент -> {array[i, j]}");
        }
    }

    if (n > rows && n < cols && m > cols && m < cols)
    {
        System.Console.WriteLine($"({n},{m}) -> такого элемента нет");
    }
}
