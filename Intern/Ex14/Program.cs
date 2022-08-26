// 14. Найти третью цифру числа или сообщить, что её нет

int EnterNum()
{
    System.Console.WriteLine("Введите трехзначное число: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}


if (num > 100 && num < 1000)
{
    int thirdNum = num % 10;
    System.Console.WriteLine($"Третья цифра числа  = {thirdNum}");
}
else if (num > 1000)
{
    int thirdNum = num / 10 % 10;
    System.Console.WriteLine($"Третья цифра числа  = {thirdNum}");
}
else System.Console.WriteLine("Третьей цифры нет");


