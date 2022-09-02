Console.Clear();

int num = GetNumberFromUser("Введите целое положительное число: ", "Ошибка ввода!");
int num2 = GetNumberFromUser("Введите целое положительное число: ", "Ошибка ввода!");
Console.WriteLine($"\t{num}^{num2} -> {NumberToPowerNumber(num, num2)}");

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
int NumberToPowerNumber(int number, int number2)
{
    if (number2 == 0)
        return 1;
    if (number2 == 1)
        return number; 
    return number * NumberToPowerNumber(number, number2 - 1);
}