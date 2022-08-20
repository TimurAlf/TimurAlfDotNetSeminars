// 7. Показать числа от -N до N

Console.Write("Введите число: ");
int x = Convert.ToInt32(Console.ReadLine());

Show(x);

void Show(int x)
{
    for (int i = -x; i <= x; i++)
    {
        Console.Write($"{i,3}");
    }
}