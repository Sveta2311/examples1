Console.Clear();

string[,] array = FillArray(4,4);
PrintArray(array);


string[,] FillArray(int n, int m)
{
    int rows = n;
    int columns = m;
    string[,] result = new string[rows, columns];
    
    int startRow = 0;
    int finishRow = rows-1;
    int startCol = 0;
    int finishCol = columns-1;
    int currentNumber = 1;
    int maxValue = rows * columns;
    while (currentNumber <= maxValue) 
        {
            for (int i = startCol; i <= finishCol; i++) 
            {
                result[startRow, i] = currentNumber.ToString("D2");
                currentNumber++;
            }
            startRow = startRow + 1;
            for (int i = startRow; i <= finishRow; i++) 
            {
                result[i, finishCol] = currentNumber.ToString("D2");
                currentNumber++;
            }
            finishCol = finishCol - 1;
            for (int i = finishCol; i >= startCol; i--) 
            {
                result[finishRow, i] = currentNumber.ToString("D2");
                currentNumber++;
            }
            finishRow = finishRow - 1;
            for (int i = finishRow; i >= startRow; i--) 
            {
                result[i, startCol] = currentNumber.ToString("D2");
                currentNumber++;
            }
            startCol = startCol + 1;
        }
    return result;
}

void PrintArray(string[,] inArray)
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