// Напишите программу, которая принимает на вход число и проверяет, 
//кратно ли оно одновременно 7 и 23
//14 -> нет
//46 -> нет
//161 -> да
void Mod()
{
int a = 161;
int b = 7, c = 23;
if (a % b == 0)
{
    if (a % c == 0)
    {
        Console.WriteLine("да");
    }
    else
    {
        Console.WriteLine("нет");
    }
}
else
{
    Console.WriteLine("нет");
}   
}
Mod();

