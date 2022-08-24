Console.Clear();
double k1 = GetCoords("Введите число k1: ");
double k2 = GetCoords("Введите число k2: ");
double b1 = GetCoords("Введите число b1: ");
double b2 = GetCoords("Введите число b2: ");

double GetCoords(string message)
{
   while(true)
      {
      Console.Write(message);
      double value;
      try 
      {
         value = Convert.ToDouble(Console.ReadLine());
         return value;
      }
        catch 
      {
         Console.WriteLine("Вы ввели не число!");
      }
    }
}

if (k1 == k2)
{
   Console.WriteLine("Прямые параллельны!");
   return;
}
else 
{
   double x = -(b1 - b2) / (k1 - k2);
   double y = k1 * x + b1;
 
   x = Math.Round(x, 2);
   y = Math.Round(y, 2);
 
   Console.WriteLine($"Точка пересечения двух прямых: ({x};{y})");
} 
