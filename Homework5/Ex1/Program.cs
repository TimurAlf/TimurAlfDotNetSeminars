// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] GetBinaryArray(int n)
{
    int[] arr = new int[n];  //создаем массив

    for (int i = 0; i < n; i++)
    {
        arr[i] = new Random().Next(100, 1000); //заполняем массив
    }
    return arr;
}

string NewPrint(int[] arr)
{
    string s = String.Empty;
    int size = arr.Length;
    for (int i = 0; i < size; i++)
    {
        s += Convert.ToString(arr[i]);
    }
    return s;
}

int Check(int[] arr)
{
    int count = 0;
    int size = arr.Length;
    for (int i = 0; i < size; i++)
    {
        if (arr[i] % 2 == 0) count += 1;
    }
    return count;
}
int[] array = GetBinaryArray(8);
string s = NewPrint(array);
int count = Check(array);
Console.Write("[{0}]", string.Join(", ", array));
Console.Write($"-> {count}");