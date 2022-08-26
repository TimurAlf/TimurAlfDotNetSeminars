//  9. Показать последнюю цифру трёхзначного числа

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
int lastNum = num % 10;
System.Console.WriteLine($"{lastNum}");

