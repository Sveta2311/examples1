Console.Clear();

int page = Number ("Введите количество страниц массива: ", "Ошибка ввода, необходимо ввести целое число > 0!");

int rows = Number("Введите количество строк массива: ", "Ошибка ввода, необходимо ввести целое число > 0!");

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

int[,,] array = GetArray(page, rows, columns, 10, 99);
PrintArray(array);

int[,,] GetArray(int p, int m, int n, int minValue, int maxValue)
{
    int[,,] result = new int[p, m, n];
    int [] usedNumbers = new int[0];
    for (int x = 0; x < p; x++)
    {
        for (int y = 0; y < m; y++)
        {
            for (int z = 0; z < n; z++)
            {
                int item = new Random().Next(minValue, maxValue);
                while (Array.IndexOf(usedNumbers,item) > -1 && usedNumbers.Length < 89)
                {
                item = new Random().Next(minValue, maxValue);
                }
                result[x, y, z] = item;
                Array.Resize(ref usedNumbers, usedNumbers.Length + 1);
                usedNumbers[usedNumbers.Length - 1] = item;

            }
        }
    }
    return result;
}

void PrintArray(int[,,] inArray)
{
    for (int x = 0; x < inArray.GetLength(0); x++)
    {
        for (int y = 0; y < inArray.GetLength(1); y++)
        {
            for (int z = 0; z < inArray.GetLength(2); z++)
            {
            Console.Write($"{inArray[x, y, z]}({x},{y},{z}) ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}