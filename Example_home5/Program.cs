Console.WriteLine("Введите целое трехзначное число:");
string number_As = Console.ReadLine() ??"";
int number_Ai;
if (!int.TryParse(number_As, out number_Ai) || number_As.Length != 3)
{
     Console.WriteLine("Ошибка ввода");
     return;
}
Console.WriteLine("Вторая цифра введенного трехзначного числа:");
Console.WriteLine(number_As.Substring(1,1));