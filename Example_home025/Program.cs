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

int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
SortDescendRows(array);

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

void SortDescendRows(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        BubbleSort(arr, i);
    }
    Console.WriteLine();
    PrintArray(arr);
}

void BubbleSort(int[,] inArray, int i)
{
    for (int j = 0; j < inArray.GetLength(1); j++)
        {
        for (int b = 0; b < inArray.GetLength(1) - j - 1; b++)
            {
                if (inArray[i, b] < inArray[i, b + 1])
                {
                int box = inArray[i, b];
                inArray[i, b] = inArray[i, b + 1];
                inArray[i, b + 1] = box;
                }
            }
    }
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
