// 10. Показать вторую цифру трёхзначного числа

int EnterNum()
{
    System.Console.WriteLine("Введите трехзначное число: ");
    int num = Convert.ToInt32(Console.ReadLine());
    while (num < 100 || num > 1000)
    {
        System.Console.WriteLine("Введите корректное число: ");
        num = Convert.ToInt32(Console.ReadLine());
    }
    return num;
}

int num = EnterNum();
int secondNum = num /10 % 10;
System.Console.WriteLine($"{secondNum}");