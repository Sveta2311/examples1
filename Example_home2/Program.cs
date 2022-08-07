Console.WriteLine("Введите первое число");
string number_As = Console.ReadLine() ??"";
double number_Ai;
Console.WriteLine("Введите второе число");
string number_Bs = Console.ReadLine() ??"";
double number_Bi;
Console.WriteLine("Ведите третье число");
string number_Cs = Console.ReadLine() ??"";
double number_Ci;
double max;
if (double.TryParse(number_As, out number_Ai))
{
  if (double.TryParse(number_Bs, out number_Bi))
   {
      if (double.TryParse(number_Cs, out number_Ci))
      {
       max = number_Ai;
       if (number_Bi> max ) max = number_Bi;
       if (number_Ci> max ) max = number_Ci;
       Console.Write("max = ");
       Console.WriteLine(max);
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
  }
  else
  {
  Console.WriteLine("Ошибка ввода");
}




