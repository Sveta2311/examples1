Console.Clear();
int size = GetArraySize("Введите колличество элементов массива: ", "Ошибка ввода, размер массива должен быть больше 0!");
int minValue = GetMinValue("Введите минимальный элемент массива: ", "Ошибка ввода, минимальный элемент массива должен быть > 99!");
int maxValue = GetMaxValue("Введите максимальный элемент массива: ", "Ошибка ввода, максимальный элемент массива должен быть больше минимального элемента массива и < 1000!", minValue);

int GetArraySize(string message, string errorMessage)
{
    while(true)
    {
        Console.Write(message);
        int size;
        if(int.TryParse(Console.ReadLine(), out size) && size > 0)
            return size;
        Console.WriteLine(errorMessage);
    }
}

int GetMinValue(string message, string errorMessage)
{
    while(true)
    {
        Console.Write(message);
        int minValue;
        if(int.TryParse(Console.ReadLine(), out minValue) && minValue > 99 && minValue < 1000)
            return minValue;
        Console.WriteLine(errorMessage);
    }
}

int GetMaxValue(string message, string errorMessage, int minValue)
{
    while(true)
    {
        Console.Write(message);
        int maxValue;
        if(int.TryParse(Console.ReadLine(), out maxValue) && maxValue > minValue && maxValue < 1000)
            return maxValue;
        Console.WriteLine(errorMessage);
    }
}

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

Console.WriteLine("Сгенерированный массив: ");
int[] numArr = GetArray(size, minValue, maxValue);
Console.WriteLine(String.Join(", ", numArr));

int chetEl = NumChetEl(numArr);

int NumChetEl(int[] arr)
{
    int res = 0;
     for (int i = 0; i < arr.Length; i++)
     {
     if (arr[i] % 2 == 0) res++;
     }
     return res;
}
Console.WriteLine("Количество четных элементов массива:");
Console.WriteLine(chetEl);
