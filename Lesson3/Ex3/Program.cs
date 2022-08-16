// Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y

bool f(bool x, bool y)
{
    //¬(X ⋁ Y) = ¬X ⋀ ¬Y
    return (!(x || y)) == (!x && !y);
}

bool IntToBool(int v)
{
    return v != 0;
}

bool res = true;
for (int x = 0; x <= 1; x++)
{
    for (int y = 0; y <= 1; y++)
    {
        res = res && f(IntToBool(x), IntToBool(y));
        Console.WriteLine($"{x} {y}= {res}");
    }
}
Console.WriteLine($"res: {res}");