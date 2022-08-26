// 13. Выяснить, кратно ли число заданному, если нет, вывести остаток.

int EnterNum()
{
    System.Console.WriteLine("Введите число: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}
int EnterNum2()
{
    System.Console.WriteLine("Введите второе число: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}


int num = EnterNum();
int num2 = EnterNum2();

if (num % num2 != 0)
{
int res = num % num2;
System.Console.WriteLine($"Число {num} не кратно {num2}, {num} % {num2} = {res} ");
}
else 
{
    int result = num /num2;
    System.Console.WriteLine($"Число {num} кратно {num2}, {num} / {num2} = {result} ");
}