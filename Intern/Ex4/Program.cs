// 4. Найти максимальное из трех чисел

Console.Write("Введите 1 число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2 число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 3 число: ");
int c = Convert.ToInt32(Console.ReadLine());

MaxNum(a, b, c);

void MaxNum(int a, int b, int c)
{
    if (a > b && a > c) System.Console.WriteLine($"{a} максимальное число");
    if (a < b && b > c) System.Console.WriteLine($"{b} максимальное число");
    if (c > a && c > b) System.Console.WriteLine($"{c} максимальное число");
}