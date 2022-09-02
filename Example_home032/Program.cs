int m = GetNumberFromUser("Введите первое целое положительное число: ", "Ошибка ввода!");
int n = GetNumberFromUser("Введите второе целое положительное число: ", "Ошибка ввода!");

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

int test = A(n, m);
Console.WriteLine("Значение функции Аккермана: ");
Console.WriteLine(test);        
static int A(int n, int m)
{
    if (n == 0) return m + 1;
    if (n != 0 && m == 0) return A(n - 1, 1);
    if (n > 0 && m > 0) return A(n - 1, A(n, m - 1));
    return A(n,m);
}



