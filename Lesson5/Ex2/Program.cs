// Задача 32: Напишите функцию замены элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// // [-4, -8, 8, 2] -> [4, 8, -8, -2]

int[] GetArray(int n)
{
    int[] Array = new int[n];  //создаем массив

    for (int i = 0; i < n; i++)
    {
        Array[i] = new Random().Next(-10, 10); //заполняем массив
    }
    return Array;
}

int[] GetArrayNull(int n)
{
    int[] Array = new int[n];  //создаем массив

    for (int i = 0; i < n; i++)
    {
        Array[i] = 0; //заполняем массив
        
    }
    return Array;
}

int[] Array = GetArray(9);
int[] NewArray = GetArrayNull(9);

int size = Array.Length;
for (int i = 0; i <= size; i++)
{
    if (Array[i] > 0) NewArray[i] = Array[i] * (-1);
    else NewArray[i] = Array[i] * (-1);
    System.Console.WriteLine("[{0}]", string.Join(", ", NewArray));
}

