Console.WriteLine("Введите число");
string number_As = Console.ReadLine() ??"";
double number_Ai;
if (double.TryParse(number_As, out number_Ai))
{
   if (number_Ai % 2 == 0)
   Console.WriteLine("Да, число является четным");
   else
   {
   Console.WriteLine("Введено не четное число");
   }
}
else
{
    Console.WriteLine("Ошибка ввода");
}

