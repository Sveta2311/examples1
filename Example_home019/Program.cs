Console.Clear();
int size = GetArraySize("Введите колличество элементов массива: ", "Ошибка ввода, размер массива должен быть больше 0!");
int minValue = GetMinValue("Введите минимальный элемент массива: ", "Ошибка ввода!");
int maxValue = GetMaxValue("Введите максимальный элемент массива: ", "Ошибка ввода, максимальный элемент массива должен быть больше минимального элемента массива!", minValue);

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
        if(int.TryParse(Console.ReadLine(), out minValue))
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
        if(int.TryParse(Console.ReadLine(), out maxValue) && maxValue > minValue)
            return maxValue;
        Console.WriteLine(errorMessage);
    }
}

double[] GetArray(int size, int minValue, int maxValue)
{
    double[] res = new double[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().NextDouble() + new Random().Next(minValue,maxValue - 1);
    }
    return res;
}

Console.WriteLine("Сгенерированный массив: ");
double[] numArr = GetArray(size, minValue, maxValue);
Console.WriteLine(String.Join(", ", numArr));

double result = resMaxMin(numArr);

double resMaxMin(double[] arr)
{
    double res = 0;
    double max = arr[0];
    double min = arr[0];

    for (int i = 1; i < arr.Length; i++)
      {
        if (arr[i] > max)
        {
            max = arr[i];
        }
        if (arr[i] < min)
        {
            min = arr[i];
        }
      }
     
    Console.WriteLine("Максимальный элемент массива: " + max);
    Console.WriteLine("Минимальный элемент массива: " + min);
      res = max - min;
      return res;
}
 Console.WriteLine("Разница между максимальным и минимальным элеменом массива:");
 Console.WriteLine(result);
