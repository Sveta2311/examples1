Console.WriteLine("Введите число: ");
string number_As = Console.ReadLine() ??"";
int number_Ai;
double cube;
if (!int.TryParse(number_As, out number_Ai) || !(number_Ai > 0))
{
     Console.WriteLine("Ошибка ввода");
     return;
}
Console.WriteLine("Все числа в кубе от 1 до " + number_As + ":");
for (int i = 1; i<= number_Ai; i++)
{
     cube = Math.Pow(i, 3);
     Console.WriteLine(cube);
}       