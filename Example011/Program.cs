int num = new Random().Next(10, 100);
int num2 = new Random().Next(1, 10);
int result = num % num2;
if (result == 0)
    Console.WriteLine ($"{num} кратно {num2}");
else 
    Console.WriteLine ($"{num} не кратно {num2}, остаток {result}");

