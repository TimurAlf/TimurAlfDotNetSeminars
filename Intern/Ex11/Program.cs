// 11. Дано число из отрезка [10, 99]. Показать наибольшую цифру числа

int EnterNum()
{
    System.Console.WriteLine("Введите трехзначное число: ");
    int num = Convert.ToInt32(Console.ReadLine());
    while (num <= 10|| num > 100)
    {
        System.Console.WriteLine("Введите корректное число: ");
        num = Convert.ToInt32(Console.ReadLine());
    }
    return num;
}

int num = EnterNum();
int firstNum = num / 10;
int secondNum = num % 10;

if(firstNum>secondNum) System.Console.WriteLine($"{firstNum}");
else System.Console.WriteLine($"{secondNum}");