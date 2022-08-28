Console.Clear();

int rows = Number("Введите количество сторок массива: ", "Ошибка ввода, необходимо ввести целое число > 0!");

int columns = Number("Введите количество столбцов массива: ", "Ошибка ввода, необходимо ввести целое число > 0!");

int Number(string message, string errorMessage)
{
    while(true)
    {
        Console.Write(message);
        int num;
        if(int.TryParse(Console.ReadLine(), out num) && num > 0)
            return num;
        Console.WriteLine(errorMessage);
    }
}

int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
ReturnAverageColumns(array);

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

double ReturnAverageColumns(int[,] inArray)
{
    double[] sumArray = new double[inArray.GetLength(1)];

    for (int i = 0; i < inArray.GetLength(0); i++)
    {

        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            sumArray[j] += inArray[i,j];
        }
            
    }
    for (int i = 0; i < sumArray.Length; i++)
        {
            Console.WriteLine($"Среднее арифмитическое столбца {i +1}:");
            Console.WriteLine("{0,4:F2}", sumArray[i]/inArray.GetLength(1));
        }
    return 0;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}