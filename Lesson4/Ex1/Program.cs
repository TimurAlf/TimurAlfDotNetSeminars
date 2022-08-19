// Сумма цифр от 1 до A.

int NewMethod(int arg)
{
    int sum = 0;
    for (int i = 0; i <= arg; i++)
    {
        sum += i;
    }
    return sum;
}

int a = 10;
int sum = NewMethod(a);

System.Console.WriteLine($"sum: {sum}"); // интерполяция строк, делается для того чтобы не смешивались типы данных