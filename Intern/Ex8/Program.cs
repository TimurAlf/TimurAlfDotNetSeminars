// 8. Показать четные числа от 1 до N

System.Console.Write("Введите число:");
int x = Convert.ToInt32(Console.ReadLine());
Show(x);

void Show(int x)
{
    for (int i = 1; i <= x; i++)
    {
        Console.Write($"{i,3}");
    }
}
