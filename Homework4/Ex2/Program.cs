// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

  int SumNumber(int num)
  {
    int count = Convert.ToString(num).Length;
    int prior = 0;
    int res = 0;

    for (int i = 0; i < count; i++)
    {
      prior = num - num % 10;
      res = res + (num - prior);
      num = num / 10;
    }
   return res;
  }

int sum = SumNumber(num);
Console.WriteLine("Сумма цифр в числе: " + sum);


