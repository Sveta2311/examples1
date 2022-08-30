Console.Clear();

int rows = Number("Введите количество сторок массива: ", "Ошибка ввода, необходимо ввести целое число > 0!");

int columns = Number("Введите количество столбцов массива: ", "Ошибка ввода, необходимо ввести целое число > 0!");

int Number(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        int num;
        if (int.TryParse(Console.ReadLine(), out num) && num > 0)
            return num;
        Console.WriteLine(errorMessage);
    }
}

double[,] array = GetArray(rows, columns, -10, 10);
PrintArray(array);
array = Replacement(array);

double[,] GetArray(int m, int n, int minValue, int maxValue)
{
    double[,] result = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().NextDouble() + new Random().Next(minValue, maxValue - 1);
        }
    }
    return result;
}

void PrintArray(double[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write("{0,6:F1}", inArray[i, j]);
        }
        Console.WriteLine();
    }
}

double[,] Replacement(double[,] arr)
{
    if (arr.GetLength(0) == arr.GetLength(1))
    {
        double box;
        for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = i; j < arr.GetLength(1); j++)
                {
                    box = arr[i, j];
                    arr[i, j] = arr[j, i];
                    arr[j, i] = box;
                }
            }
    }
    else
        Console.WriteLine("Невозможно преобразовать массив!");
    Console.WriteLine();
    PrintArray(arr);
    return arr;
}
