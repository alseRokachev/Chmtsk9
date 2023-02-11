// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30

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
            return number;
        }
        System.Console.WriteLine("Некорректное число");
    }
}

int sumNumbs(int numb1, int numb2)
{
    if (numb1 < numb2)
    {
        if (numb1 >= 0 && numb2 >= 0)
        {
            return numb1 + sumNumbs(numb1 + 1, numb2); /* если оба числа > 0 */
        }
        else if (numb1 < 0 && numb2 > 0)
        {
            return 0 + sumNumbs(numb1 + 1, numb2); /* если первое число < 0 */
        }
        else /* если оба числа < 0*/
        {
            System.Console.WriteLine("Некорректно введены числа");
        }
    }
    else if (numb1 > numb2)
    {
        System.Console.WriteLine("Первое число должно быть < второго");
    }
    return numb2;
}


int numb1 = numbCheck("Введите первое число: ");
int numb2 = numbCheck("Введите второе число: ");

System.Console.WriteLine(sumNumbs(numb1, numb2));