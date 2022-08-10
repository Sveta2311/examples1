Console.WriteLine("Введите число:");
string number_As = Console.ReadLine() ??"";
int number_Ai;
if (!int.TryParse(number_As, out number_Ai))
{
    Console.WriteLine("Ошибка ввода");
    return;
}
if (number_As.Length < 3)
{
    Console.WriteLine("Третьей цифры нет в веденном числе");
    return;
}
Console.WriteLine("Третья цифра введенного числа:");
Console.WriteLine(number_As.Substring(2,1));
