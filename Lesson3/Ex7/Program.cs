// Задача 22: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,

int N = new Random().Next(1, 10);
System.Console.WriteLine(N);

for (int i = 1; i <= N; i++)
{
    int result = i*i;
    System.Console.WriteLine(result);
}
