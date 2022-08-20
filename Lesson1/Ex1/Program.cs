// Напишите программу, которая на вход принимает число и выдает его квадрат
// например -4 = 16
// например -3 = 9
// например -7 = 49

int num = new Random().Next(-10, 10);
System.Console.Write(num + " * " + num +" = ");
int result = NewMethod(num);
Console.Write($"{result}");

int NewMethod(int num)
{
    return num * num;
}