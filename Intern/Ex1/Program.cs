//  Почувствуй себя интерном*
//  0. Вывести квадрат числа

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

NewMethod(num);

void NewMethod(int num)
{
    int result = num * num;
    System.Console.WriteLine($"{num} * {num} = {result}");
}