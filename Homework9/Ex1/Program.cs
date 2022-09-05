
// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> ""1, 2, 3, 4, 5""
// M = 4; N = 8. -> ""4, 6, 7, 8""

int n, m;

EnterNumbers(out n, out m);

PrintNumbers(ref n, ref m);

void EnterNumbers(out int n, out int m)
{
    System.Console.WriteLine("Введите число n>0: ");
    n = Convert.ToInt32(Console.ReadLine());
    System.Console.WriteLine("Введите число m>0: ");
    m = Convert.ToInt32(Console.ReadLine());
}

void PrintNumbers(ref int n, ref int m)
{
    if (n > 0 && m > 0)
    {
        for (int i = n; i <= m; i++)
        {
            System.Console.Write($"{i}, ");
        }
    }
    else
    {
        while (n < 0 || m < 0)
        {
            System.Console.WriteLine("Введите корректное значение");
            EnterNumbers(out n, out m);
        }
    }
}