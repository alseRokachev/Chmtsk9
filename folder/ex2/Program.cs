// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n. 
// m = 2, n = 3 -> A(m,n) = 29

int numbCheck(string str)
{
    int number;
    string? text;
    while (true)
    {
        System.Console.Write(str);
        text = Console.ReadLine();
        if (int.TryParse(text, out number))
        {
            if (number > 0)
            {
                return number;
            }
        }
        System.Console.WriteLine("Некорректное число");
    }
}

int Ackerman(int numb1, int numb2)
{
    if (numb1 == 0)
    {
        return numb2 + 1;
    }
    if (numb1 > 0 && numb2 == 0)
    {
        return Ackerman(numb1 - 1, 1);
    }
    if (numb1 > 0 && numb2 > 0)
    {
        return Ackerman(numb1 - 1, Ackerman(numb1, numb2 - 1));
    }
    return 0;
}

int numb1 = numbCheck("Введите первое число: ");
int numb2 = numbCheck("Введите второе число: ");

System.Console.WriteLine($"Ответ: {Ackerman(numb2, numb1)}");