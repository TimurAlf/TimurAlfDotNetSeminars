// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

int[] GetArray(int n)
{
    int[] Array = new int[n];  //создаем массив

    for (int i = 0; i < n; i++)
    {
        Array[i] = new Random().Next(1, 10); //заполняем массив
    }
    System.Console.WriteLine("[{0}]", string.Join(", ", Array));
    return Array;
}

int[] Array = GetArray(5);
int size = Array.Length;
for (int i = 0; i <= size / 2; i++)
{
    int result = Array[i] * (Array[size - 1 - i]);
    System.Console.WriteLine($"{result}");

}