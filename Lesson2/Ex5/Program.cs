// Напишите программу, которая принимает на вход 2 числа и проверят является ли одно
// квадратом другого
//5,25 да
//-4,16 да
//25,5 да
//8,9 нет

int a = 4, b = 8;
if (a * a == b)
{
    Console.WriteLine("yes");
}
else
{
    if (b * b == a)
    {
        Console.WriteLine("yes");
    }
    else
    {
        Console.WriteLine("no");
    }
}

