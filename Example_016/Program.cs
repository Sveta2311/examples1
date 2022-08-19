class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите колличество элементов массива:");
        int size = Convert.ToInt32(Console.ReadLine());
        int[] myArray = GetArray(size);

        for (int i = 0; i < myArray.Length; i++)
        {
            myArray[i] *= (-1);
        }
        Console.WriteLine("\nВывод массива: ");
        Console.WriteLine(String.Join(", ", myArray));
    }

    static int[] GetArray(int length)
    {
        int[] myArray = new int[length];
        for (int i = 0; i < length; i++)
        {
            Console.Write($"\nВведите элемент массива под индексом {i}: ");
            myArray[i] = Convert.ToInt32(Console.ReadLine());
        }
        return myArray;
    }
}