// Как ограничить пользователя, чтобы он ввел только число от -10 до 10.

int GetTryParse(string v)
{
    int a = -20;

    while (true)
    {
        bool f = true;
        Console.Write(v);                    //показали текст
        string s = Console.ReadLine();           //считали данные

        for (int i = 0; i < s.Length; i++)      //пробежадись по всем символам строки
            if (!(s[i] >= '0' && s[i] <= '9'))
            {
                f = false;
                continue;    //если нашелся символ который не удовлетворяет условию 
            }                //то отправляет на повторный ввод
        if (f)
        {
            a = int.Parse(s);
            if( a >= -10 && a <= 10)
            break;
        }
    }
    return a;
}
int a = GetTryParse("Введите только число от -10 до 10:  ");