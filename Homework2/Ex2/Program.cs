/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/
void Show()
{
    int show = new Random().Next(1, 10000);
    int c = 99;
    int a = show / 10;
    int b = a % 10;
    if (show > c)
    {
        Console.WriteLine(show);
        Console.Write(b);
    }
    else
    {
        Console.WriteLine("третьей цифры нет ");
    }
}
Show();




