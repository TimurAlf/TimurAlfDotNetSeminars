/* Напишите программу, которая принимает на вход координаты точки (X и Y), 
причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, 
в которой находится эта точка.
*/

int x = new Random().Next(-10, 10);
int y = new Random().Next(-10, 10);

System.Console.WriteLine("x = " + x + "; " + "y = " + y);

if (x == 0 ^ y == 0)
{
    System.Console.WriteLine("Точка лежит на оси координат");
}
else
{
    if (x > 0 && y > 0)
    {
        System.Console.WriteLine("Точка лежит в 1 четверти");
    }
    else
    {
        if (x < 0 && y > 0)
        {
            System.Console.WriteLine("Точка лежит во 2 четверти");
        }
        else
        {
            if (x < 0 && y < 0)
            {
                System.Console.WriteLine("Точка лежит в 3 четверти");
            }
            else
            {
                if (x > 0 && y < 0)
                {
                    System.Console.WriteLine("Точка лежит в 4 четверти");
                }
            }

        }
    }
}

