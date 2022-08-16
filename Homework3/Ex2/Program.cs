// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// int x1 = new Random().Next(-10, 10), x2 = new Random().Next(1, 5), x3 = new Random().Next(1, 5);
// int y1 = new Random().Next(-10, 10), y2 = new Random().Next(1, 5), y3 = new Random().Next(1, 5);

// d= ((x2-x1)^2 + (y2-y1)^2+ (z2-z1)^2)^1\2

(int x, int y, int z) A, B;
A = (3, 6, 8);
B = (2, 1, -7);
System.Console.WriteLine("Координата точки A(" + A.x + "," + A.y + "," + A.z + ")");
System.Console.WriteLine("Координата точки B(" + B.x + "," + B.y + "," + B.z + ")");
System.Console.Write("Расстояние между точками А и В в 3D пространстве равно: ");
double result = Math.Pow(Math.Pow((B.x - A.x),2)+Math.Pow((B.y - A.y),2)+Math.Pow((B.z - A.z),2),0.5);
System.Console.Write(result);