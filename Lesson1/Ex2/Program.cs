// Напишите программу, которая на вход принимает 2 числа и проверяет,
// является ли первое число квадратом второго.
// a = 25, b = 5
// a = 2 b = 10
// a = 9 b = -3
// a = -3 b - 9

int a = new Random().Next(-10, 10), b = new Random().Next(-10, 10);
System.Console.WriteLine("Первое число: "+ a);
System.Console.WriteLine("Второе число: "+ b);
Check(a, b);

void Check(int a, int b)
{
    if (a == b * b)
    {
        Console.WriteLine("Первое число, является квадратом второго");
    }
    else
    {
        Console.WriteLine("Первое число не является квадратом второго");
    }
}