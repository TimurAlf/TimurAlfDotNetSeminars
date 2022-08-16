//Как ограничить пользователя, чтобы он ввел только число от -10 до 10.
//Как можно упростить? использовать int.TryParse

int GetTryParse(string v)
{
    int a = -20;
    while (true)
    {
        Console.Write(v);
        string s = Console.ReadLine();
        bool f = int.TryParse(s, out a); // оператор пытается превратить строку в тип который мы указали
        if (f && a >= -10 && a <= 10)
        return a;
    }   
}
int a = GetTryParse("Введите только число от -10 до 10:  ");
