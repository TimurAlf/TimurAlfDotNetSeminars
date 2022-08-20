// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] GetBinaryArray(int n)
{
    int[] arr = new int[n];  //создаем массив

    for (int i = 0; i < n; i++)
    {
        arr[i] = new Random().Next(-10, 10); //заполняем массив
    }
    return arr;
}

string NewPrint(int[] arr) //метод, принимает массив и куда-то кладет результат, куда не важно :D
{
    string s = String.Empty; // создание пустой строки
    int size = arr.Length;
    for (int i = 0; i < size; i++)
    {
        s += Convert.ToString(arr[i]); // добавляем в строку число из массива, конвертируя его в строчный тип
    }
    return s;
}
int[] array = GetBinaryArray(8);
string s = NewPrint(array);
//System.Console.WriteLine("["+ res[0] + "," + res[1] + "," + res[2] + "," + res[3] + "," + res[4] + "," + res[5] + "," + res[6] + "," + res[7]+"]");
Console.WriteLine("[{0}]", string.Join(", ", array));