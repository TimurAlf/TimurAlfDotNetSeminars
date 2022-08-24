// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int Count(int[] arr)
{
    int size = arr.Length;
    int count = 0;
    for (int i = 0; i < size; i++)
    {
        if (arr[i] > 0) count += 1;
    }
    return count;
}

int[] GetArray(int n)
{
    int[] arr = new int[n];
    for (int i = 0; i < n; i++)
    {
        System.Console.WriteLine("Введите число: ");
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
    return arr;
}
int[] array = GetArray(8);
int res = Count(array);
Console.Write("[{0}]", string.Join(", ", array));
Console.Write($"-> {res}");
