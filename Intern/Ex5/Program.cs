//5. Написать программу вычисления значения функции y = f(a)

// for example: y = kx + m;

Console.Write("Введите k число: ");
int k = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите x число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите m число: ");
int x = Convert.ToInt32(Console.ReadLine());

NewMethod(k, m, x);

void NewMethod(int k, int m, int x)
{
    int y = k * x + m;
    System.Console.WriteLine($"y = {k} * {x} + {m}");
    System.Console.WriteLine($"y = {y}");
}