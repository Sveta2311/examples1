Console.WriteLine("Введите номер дня недели от 1 до 7: ");
string? a1 = Console.ReadLine();

int b1;

if (int.TryParse(a1, out b1))
{
    if (b1 == 1) Console.WriteLine("Понедельник");
    else if (b1 == 2) Console.WriteLine("Вторник");
    else if (b1 == 3) Console.WriteLine("Среда");
    else if (b1 == 4) Console.WriteLine("Четверг");
    else if (b1 == 5) Console.WriteLine("Пятница");
    else if (b1 == 6) Console.WriteLine("Суббота");
    else if (b1 == 7) Console.WriteLine("Воскресенье");
    else Console.WriteLine("Ошибка ввода! Введите число от 1 до 7!");
}
else Console.WriteLine("Ошибка ввода! Повторите ввод!");
