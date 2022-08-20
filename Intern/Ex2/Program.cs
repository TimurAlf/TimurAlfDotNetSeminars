// 1. По двум заданным числам проверять является ли первое квадратом второго

Console.Write("Введите 1 число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2 число: ");
int b = Convert.ToInt32(Console.ReadLine());


Condition();

void Condition()
{
    if (b * b == a)
    {
        System.Console.WriteLine($"Число {a} является квадратом числа {b}.");
    }
    else
    {
        System.Console.WriteLine($"Число {a} не является квадратом числа {b}.");
    }
}