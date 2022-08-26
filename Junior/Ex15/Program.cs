// 15. Дано число. Проверить кратно ли оно 7 и 23

int EnterNum()
{
    System.Console.WriteLine("Введите трехзначное число: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int num = EnterNum();
int number1 = 7;
int number2 = 23;
int res1=num % number1;
int res2=num % number2;

if (res1 == 0)
{
    if (res2 == 0)
    {
        System.Console.WriteLine($"Число {num} кратно и {number1}, и {number2}");
    }
    else System.Console.WriteLine($"Число {num} кратно {number1}");
}
else if(res2 == 0)
{
    if (res1 == 0)
    {
        System.Console.WriteLine($"Число {num} кратно и {number1}, и {number2}");
    }
    else System.Console.WriteLine($"Число {num} кратно {number2}");
}
else System.Console.WriteLine($"Число {num} не кратно ни {number1}, ни {number2}");