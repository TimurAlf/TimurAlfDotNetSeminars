// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] GetBinaryArray(int n)
{
    double[] arr = new double[n];  

    for (int i = 0; i < n; i++)
    {
        arr[i] = new Random().NextDouble() * (10 - 0) + 0; 
    }
    return arr;
}

string NewPrint(double[] arr)
{
    string s = String.Empty;
    double size = arr.Length;
    for (int i = 0; i < size; i++)
    {
        s += Convert.ToString(arr[i]+", ");
    }
    return s;
}

double Max (double[] arr)
{
    int size = arr.Length;
    double max = arr[0];
    for (int i = 0; i < size; i++)
    {
        if (arr[i] > max)
        {
            max = arr[i];
        }
    }
    return max;
}

double Min (double[] arr)
{
    int size = arr.Length;
    double min = arr[0];
    for (int i = 0; i < size; i++)
    {
        if (arr[i] < min)
        {
            min = arr[i];
            
        }
    }
    return min;
}
double[] array = GetBinaryArray(8);
string s = NewPrint(array);
double min = Min(array);
double max = Max(array);
double result = max-min;
//Console.Write("[{0}]", string.Join(", ", array));
System.Console.WriteLine(s);
Console.Write($" {max} - {min} = {result}");

