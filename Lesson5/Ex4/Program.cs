// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

int[] GetArray(int n)
{
    int[] Array = new int[n];  //создаем массив

    for (int i = 0; i < n; i++)
    {
        Array[i] = new Random().Next(1, 1000); //заполняем массив
    }
    System.Console.WriteLine("[{0}]", string.Join(", ", Array));
    return Array;
}

int[] Array = GetArray(123);

int size = Array.Length;
int count = 0;
for (int i = 0; i < size; i++)
{
    if (10 <= Array[i] && Array[i] < 100)
    {
        count += 1;
        System.Console.WriteLine(Array[i]);
    }

}
System.Console.WriteLine($"count: {count}");

// if (s == true) System.Console.WriteLine("Yep");
// else System.Console.WriteLine("No");

