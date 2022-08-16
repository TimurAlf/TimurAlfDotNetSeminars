// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

int N = new Random().Next(1, 10);
System.Console.WriteLine(N);

for (int i = 1; i <= N; i++)
{
    int result = i*i*i;
    System.Console.WriteLine(result);
}