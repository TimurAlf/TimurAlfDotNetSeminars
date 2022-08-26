// 12. Удалить вторую цифру трёхзначного числа

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
int thirdNum = num % 10;
int resNum = num /100;
System.Console.WriteLine($"{resNum}{thirdNum}");
