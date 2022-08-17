class Program
{
    static void Main(string[] args)
    {
        string[] myArray = new string[8];

        for (int i = 0; i < myArray.Length; i++)
        {
            Console.Write($"\nВведите элемент массива под индексом {i}: ");
            myArray[i] = Console.ReadLine();
        }
    Console.WriteLine("\nВывод массива: ");
    Console.WriteLine(String.Join(", ", myArray));
    }
}
