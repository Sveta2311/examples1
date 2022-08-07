Console.WriteLine("Введите число число больше или равное 1");
string number_As = Console.ReadLine() ??"";
double number_Ai;
if (!double.TryParse(number_As, out number_Ai))
{
     Console.WriteLine("Ошибка ввода");
     return;
}
if (number_Ai < 1)
{ 
     Console.WriteLine("Введенное число меньше 1");
     return;
}
if (number_Ai == 1)
{ 
     Console.WriteLine("Нет четных чисел в промежутке от 1 до " + number_As);
     return;
}     
Console.WriteLine("Все четные числа от 1 до " + number_As + ":");
for (int i = 1; i<= number_Ai; i++)
{
     if (i % 2 == 0)
     {
          Console.WriteLine(i);
     }
}       
 
