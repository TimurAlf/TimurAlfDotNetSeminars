// 3. По заданному номеру дня недели вывести его название

Console.Write("Введите номер дня недели: ");
int num = Convert.ToInt32(Console.ReadLine());
Week(num);

void Week(int num)
{
    if (num <= 0) System.Console.WriteLine("Дней недели всего 7");
    if (num == 1) System.Console.WriteLine("Пн");
    if (num == 2) System.Console.WriteLine("Вт");
    if (num == 3) System.Console.WriteLine("Ср");
    if (num == 4) System.Console.WriteLine("Чт");
    if (num == 5) System.Console.WriteLine("Пт");
    if (num == 6) System.Console.WriteLine("Сб");
    if (num == 7) System.Console.WriteLine("Вс");
    if (num > 7) System.Console.WriteLine("Дней недели всего 7");
}

