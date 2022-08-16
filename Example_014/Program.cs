int CountNumber(int num)
{
    int i=0;
    while(num > 0)
    {
        num/=10;
        i++;
    }
    return i;
}

int number;
Console.WriteLine("Ведите любое число: ");
number = int.Parse(Console.ReadLine()?? "");
number = CountNumber(number);

Console.Write($"Число состоит из {number} цифр");