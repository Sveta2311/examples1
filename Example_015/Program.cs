int CalculatorFactorial(int num)
{
    int result = 1, i=1;
    while (i <= num)
    {
        result*=i;
        i++;
    }
    return result;
}

Console.WriteLine("Ведите любое число: ");
int userNumber = int.Parse(Console.ReadLine()?? "");
int factorial = CalculatorFactorial(userNumber);

Console.Write($"Факториал числа {userNumber} = {factorial}");
