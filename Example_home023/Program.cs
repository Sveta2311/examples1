Console.Clear();

int rows = Number("Введите количество сторок массива: ", "Ошибка ввода, необходимо ввести целое число > 0!");
int columns = Number("Введите количество столбцов массива: ", "Ошибка ввода, необходимо ввести целое число > 0!");

int userRow = Number("Введите номер строки, занимаемого элемента: ", "Ошибка ввода, необходимо ввести целое число > 0!");
int userColumn = Number("Введите номер столбца, занимаемого элемента: ", "Ошибка ввода, необходимо ввести целое число > 0!");

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

double[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);

ArrayElement(array, userRow, userColumn);

double[,] GetArray(int m, int n, int minValue, int maxValue)
{
    double[,] result = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().NextDouble() + new Random().Next(minValue,maxValue - 1);
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
            Console.Write("{0,6:F2}", inArray[i, j]); 
        }
        Console.WriteLine();
    }
}

double ArrayElement(double[,] inArray, int i, int j)
{
    if (i >= inArray.GetLength(0) || j >= inArray.GetLength(1))
    {
    Console.WriteLine("Элемента на заданной позиции " + i + j + " не существует!");
    }
    else
    {
    Console.WriteLine("{0,6:F2}", inArray[i-1, j-1]); 
    }
return 0;
}

