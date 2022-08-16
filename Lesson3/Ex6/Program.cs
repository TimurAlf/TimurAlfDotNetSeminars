// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21
// d= ((x2-x1)^2 + (y2-y1)^2)^1\2

int x1 = new Random().Next(-10, 10), x2 = new Random().Next(1, 5);
int y1 = new Random().Next(-10, 10), y2 = new Random().Next(1, 5);

/*либо использовать кортеж для заполнения координат
(int x, int y) a, b;
a = (1, 2);
b = (3, 4);
System.Console.WriteLine(a.x);
System.Console.WriteLine(b.y);
*/

System.Console.WriteLine("Координата точки A("+x1+","+y1+")");
System.Console.WriteLine("Координата точки B("+x2+","+y2+")");
System.Console.Write("Расстояние между точками А и В в 2D пространстве равно: ");
double result = Math.Pow(((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2)), 0.5);
System.Console.Write(result);
