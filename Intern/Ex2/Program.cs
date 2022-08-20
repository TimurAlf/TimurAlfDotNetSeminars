// 2. Даны два числа. Показать большее и меньшее число

Console.Write("Введите 1 число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2 число: ");
int b = Convert.ToInt32(Console.ReadLine());

Сomparison(a, b);

static void Сomparison(int a, int b)
{
    if (a > b)
    {
        System.Console.WriteLine($"{a} > {b}");
    }
    else
    {
        System.Console.WriteLine($"{a} < {b}");
    }
}