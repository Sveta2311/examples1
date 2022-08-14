internal class Program
{
static int inputCoord()
{
   try
   {
     return int.Parse(Console.ReadLine());
   }
   catch (Exception exc)
   {
   Console.WriteLine(exc.Message);
   }
   return 0;
}
private static void Main(string[] args)
{
   Console.Clear();
     
     Console.WriteLine("Ведите x1: ");
     double x1 = inputCoord();

     Console.WriteLine("Ведите y1: ");
     double y1 = inputCoord();

     Console.WriteLine("Ведите z1: ");
     double z1 = inputCoord();

     Console.WriteLine("Ведите x2: ");
     double x2 = inputCoord();

     Console.WriteLine("Ведите y2: ");
     double y2 = inputCoord();

     Console.WriteLine("Ведите z2: ");
     double z2 = inputCoord();

     double res = Math.Sqrt(Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2) + Math.Pow((z1 - z2), 2));
     Console.Write(Math.Round(res, 2));
}
}