double[] GetBinaryArray(int n)
{
    double[] arr = new double[n];  

    for (int i = 0; i < n; i++)
    {
        arr[i] = new Random().NextDouble() * (100 - 0) + 0; //заполняем массив
    }
    return arr;
}

string NewPrint(double[] arr)
{
    string s = String.Empty;
    int size = arr.Length;
    for (int i = 0; i < size; i++)
    {
        s += Convert.ToString(arr[i]);
    }
    return s;
}

double[] array = GetBinaryArray(8);
string s = NewPrint(array);

Console.Write("[{0}]", string.Join(", ", array));
