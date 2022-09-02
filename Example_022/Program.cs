Console.WriteLine("Введите число => 1: ");
string number_As = Console.ReadLine() ?? "";
int number_Ai;
if (!int.TryParse(number_As, out number_Ai))
{
    Console.WriteLine("Ошибка ввода");
    return;
}
if (number_Ai < 1)
{
    Console.WriteLine("Введенное число меньше 1");
    return;
}

PrintNaturalsNambers(1, number_Ai);

string PrintNaturalsNambers(int start, int end)
{
    if (start == end + 1)
        return start.ToString();
    else
    {
        if (start == end)
            Console.Write($"{start}");
        else
            Console.Write($"{start}, ");
        return PrintNaturalsNambers(start + 1, end);
    }
}

