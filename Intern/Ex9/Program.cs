//  9. Показать последнюю цифру трёхзначного числа

int EnterNum()
{
    System.Console.WriteLine("Введите трехзначное число: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int num = EnterNum();
if (num > 100 && num < 1000)
{
    int lastNum = num % 10;
    System.Console.WriteLine($"{lastNum}");
}
else
{
    int num2 = EnterNum();
}
