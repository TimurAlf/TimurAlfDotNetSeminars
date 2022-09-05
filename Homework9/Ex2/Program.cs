// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

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
        int sum=0;
        for (int i = n; i <= m; i++)
        {
            sum+=i;
        }
        System.Console.Write($"Сумма элементов от {n} до {m} равна {sum}");
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