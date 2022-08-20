// 6. Выяснить является ли число чётным

Console.Write("Введите число: ");
int x = Convert.ToInt32(Console.ReadLine());
Check(x);

void Check (int x)
{
    if(x%2==0)System.Console.WriteLine($"Число {x} четное");  
    else System.Console.WriteLine($"Число {x} нечетное");      
}