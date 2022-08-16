// Задача 18: Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой четверти (x и y).

int coord = new Random().Next(1, 5);
System.Console.WriteLine("Четверть: "+ coord);
System.Console.Write("Диапозон возможных координат: ");
if (coord == 1) System.Console.Write("x > 0 и y > 0");
if (coord == 2) System.Console.Write("x < 0 и y > 0");
if (coord == 3) System.Console.Write("x < 0 и y < 0");
if (coord == 4) System.Console.Write("x > 0 и y < 0");

