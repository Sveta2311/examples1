Console.WriteLine("Введите номер четверти:");
int q = 0;
try 
{
    q = int.Parse(Console.ReadLine());
}
catch (Exception exc)
{
   Console.WriteLine(exc.Message); 
}
switch (q)
{
    case 1:
    Console.WriteLine("x > 0 и y > 0");
    break;
    case 2:
    Console.WriteLine("x < 0 и y > 0");
    break;
    case 3:
    Console.WriteLine("x < 0 и y < 0");
    break;
    case 4:
    Console.WriteLine("x > 0 и y < 0");
    break;
    default:
    Console.WriteLine("Неверно введен номер четверти");
    break;
}
