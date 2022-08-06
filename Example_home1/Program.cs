Console.WriteLine("Введите первое число");
string number_As = Console.ReadLine() ??"";
double number_Ai;
Console.WriteLine("Введите второе число");
string number_Bs = Console.ReadLine() ??"";
double number_Bi;
if (double.TryParse(number_As, out number_Ai))
{
   if (double.TryParse(number_Bs, out number_Bi))
   {
      if (number_Ai == number_Bi)
      {
         Console.WriteLine("Числа совпадают: " + number_As);
      }
      else
      {
         if (number_Ai < number_Bi) 
         {
            Console.WriteLine("max = " + number_Bs);
            Console.WriteLine("min = " + number_As);
         } 
         else 
         {
            Console.WriteLine("min = " + number_Bs);
            Console.WriteLine("max = " + number_As);
         }   
      } 
   }
   else
   {
      Console.WriteLine("Ошибка ввода");
   }
}
else
{
    Console.WriteLine("Ошибка ввода");
}
