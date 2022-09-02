int num = GetNumberFromUser("Введите целое положительное число: ", "Ошибка ввода!");

int num2 = GetNumberFromUser("Введите целое положительное число: ", "Ошибка ввода!");

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
    PrintNaturalsNambers(num, num2);

string PrintNaturalsNambers(int start, int end)
{
    if (start == end + 1)
        return start.ToString();
    else
    {
        if (start == end)
            Console.Write($"{start}");
        else
            Console.Write($"{start}, ");
        return PrintNaturalsNambers(start + 1, end);
    }
}

