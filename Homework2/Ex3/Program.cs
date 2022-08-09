/* Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/
void Weekend()
{
    int x = Convert.ToInt32(Console.ReadLine());
    if (x == 1)
    {
        Console.WriteLine("нет");
    }
    if (x == 2)
    {
        Console.WriteLine("Нет");
    }
    if (x == 3)
    {
        Console.WriteLine("Нет!");
    }
    if (x == 4)
    {
        Console.WriteLine("Нет");
    }
    if (x == 5)
    {
        Console.WriteLine("Нет");
    }
    if (x == 6)
    {
        Console.WriteLine("Выходной");
    }
    if (x == 7)
    {
        Console.WriteLine("Выходной");
    }
    if (x > 7)
    {
        Console.WriteLine("Дней недели всего 7 :)");
    }
}
Weekend();
