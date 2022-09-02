Console.Clear();

int num = GetNumberFromUser("Введите целое положительное число: ", "Ошибка ввода!");
Console.WriteLine("Сумма цифр в введенном числе:");
Console.WriteLine($"\t{num} -> {GetSumDigits(num)}");

int GetNumberFromUser(string message, string errorMessage)
{
    while(true)
    {
        Console.Write(message);
        int userNumber;
        bool isCorrect = int.TryParse(Console.ReadLine(), out userNumber);
        if(isCorrect && userNumber >=0)
            return userNumber;
        Console.WriteLine(errorMessage);
    }
}
int GetSumDigits(int number)
{
    if (number == 0)
    return 0;
    return number % 10 + GetSumDigits(number / 10);
}
