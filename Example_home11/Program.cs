Console.Clear();
Console.WriteLine("Введите первое число: ");
string number_As = Console.ReadLine() ??"";
double number_Ai;
Console.WriteLine("Введите второе натуральное (положительное и больше 0) число: ");
string number_Bs = Console.ReadLine() ??"";
int number_Bi;
double stepen;
if (!double.TryParse(number_As, out number_Ai))
{
     Console.WriteLine("Ошибка ввода, повторите ввод!");
     return;
}

if (!int.TryParse(number_Bs, out number_Bi) || number_Bi < 0)
{
     Console.WriteLine("Ошибка ввода, возможно, вы ввели не целое или отрицательное число, повторите ввод!");
     return;
}

Console.WriteLine("Первое введенное число, возведенное в натуральную степень второго введенного числа: ");

{
     stepen = Math.Pow(number_Ai, number_Bi);
     Console.WriteLine(stepen);
}       

