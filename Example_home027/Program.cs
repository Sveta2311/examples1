Console.Clear();

int rowsA = Number("Введите количество сторок массива A: ", "Ошибка ввода, необходимо ввести целое число > 0!");

int columnsA = Number("Введите количество столбцов массива A: ", "Ошибка ввода, необходимо ввести целое число > 0!");

int rowsB = Number("Введите количество сторок массива B: ", "Ошибка ввода, необходимо ввести целое число > 0!");

int columnsB = Number("Введите количество столбцов массива B: ", "Ошибка ввода, необходимо ввести целое число > 0!");

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

int[,] array = GetArray(rowsA, columnsA, 0, 10);
Console.WriteLine("Массив А: ");
PrintArray(array);

int[,] array2 = GetArray(rowsB, columnsB, 0, 10);
Console.WriteLine("Массив B: ");
PrintArray(array2);

MultiplyArrays(array, array2);

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

int MultiplyArrays(int [,] arrayA, int [,] arrayB)
{

    if (arrayA.GetLength(1) != arrayB.GetLength(0))
    {
        Console.WriteLine("Умножение не возможно, так как количество столбцов первой матрицы не равно количеству строк второй матрицы.");
        return 0;
    }

    int[,] result = new int[arrayA.GetLength(0), arrayB.GetLength(1)];
    for (int i = 0; i < arrayA.GetLength(0); i++)
    {
        for (int j = 0; j < arrayB.GetLength(1); j++)
        {
            result[i, j] = 0;
            for (var k = 0; k < arrayA.GetLength(1); k++)
                {
                    result[i, j] += arrayA[i, k] * arrayB[k, j];
                }
        }
    }
    Console.WriteLine("Произведение массивов:");
    PrintArray (result);
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
