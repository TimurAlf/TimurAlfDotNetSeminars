// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] GetBinaryArray(int n)
{
    int[] arr = new int[n];  //создаем массив

    for (int i = 0; i < n; i++)
    {
        arr[i] = new Random().Next(1, 10); //заполняем массив
    }
    return arr;
}

string NewPrint(int[] arr)
{
    string s = String.Empty;
    int size = arr.Length;
    for (int i = 0; i < size; i++)
    {
        s += Convert.ToString(arr[i]+", ");
    }
    return s;
}

int Sum(int[] arr)
{
    int size = arr.Length;
    int sum = 0;
    for (int i = 0; i < size; i++)
    {
        if (arr[i] % 2 != 0) sum += arr[i];
    }
    return sum;
}

int[] array = GetBinaryArray(8);
string s = NewPrint(array);
int sum = Sum(array);
//Console.Write("[{0}]", string.Join(", ", array));
System.Console.Write(s);
Console.Write($"-> {sum}");