Console.Clear();

int rows = Number("Введите количество сторок массива: ", "Ошибка ввода, необходимо ввести целое число > 0!");

int columns = Number("Введите количество столбцов массива: ", "Ошибка ввода, необходимо ввести целое число > 0 и не равное количеству строк массива!", rows);

int Number(string message, string errorMessage, int i = 0)
{
    while (true)
    {
        Console.Write(message);
        int num;
        if (int.TryParse(Console.ReadLine(), out num) && num > 0 && num != i)
            return num;
        Console.WriteLine(errorMessage);
    }
}

int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
SumRow(array);

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

int SumRow(int[,] inArray)
{
    int[] sumArray = new int[inArray.GetLength(0)];
    for (int j = 0; j < inArray.GetLength(1); j++)
    {
        for (int i = 0; i < inArray.GetLength(0); i++)
        {
            sumArray[i] += inArray[i, j];
        }
    }
    MinSumRows(sumArray);
    return 0;
}

int MinSumRows(int[] sumarray)
{
    int min = sumarray[0];
    int itemIndex = 0;
    for (int i = 1; i < sumarray.Length; i++)
    {
        if (sumarray[i] < min)
        {
            min = sumarray[i];
            itemIndex = i;
        }
    }
    Console.WriteLine("Номер строки с наименьшей суммой элементов: ");
    Console.WriteLine(itemIndex + 1);
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