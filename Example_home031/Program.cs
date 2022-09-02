int num = GetNumberFromUser("Введите первое целое положительное число: ", "Ошибка ввода!");
int num2 = GetNumberFromUser("Введите второе целое положительное число: ", "Ошибка ввода!");
int sum = 0;

int GetNumberFromUser(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        int userNumber;
        bool isCorrect = int.TryParse(Console.ReadLine(), out userNumber);
        if (isCorrect && userNumber >= 0)
            return userNumber;
        Console.WriteLine(errorMessage);
    }
}

if (num > num2)
{
    Console.Write("Ошибка ввода, второе введенное число должно быть больше первого!");
    return;
}
else
    sum = SumNaturalsNambers(num, num2, 0);
Console.WriteLine($"Сумма натуральных чисел в веденном прмежутке: {sum}");

int SumNaturalsNambers(int start, int end, int sum)
{
    if (start == end)
    {
        return sum += start;
    }
    else
    {
        sum += start;
        return SumNaturalsNambers(start + 1, end, sum);
    }

}