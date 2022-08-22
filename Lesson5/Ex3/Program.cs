// Задача 33: Задайте массив. Напишите функцию, которая определяет, присутствует ли заданное число в массиве.
// решать без встроенных функций
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

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

System.Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

Search();

void Search()
{
    int[] arr = GetArray(5);
    int size = arr.Length;
    bool s = true;
    for (int i = 0; i < size; i++)
    {
        if (arr[i] == a) s = true;
        else s = false;
    }
    if (s == true) System.Console.WriteLine($"В данном ассиве есть число {a}");
    else System.Console.WriteLine($"В данном массиве нету числа {a}");
}


