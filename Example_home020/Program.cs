Console.Clear();

int result = 0;
double number;

while(true)
    {
        Console.Write("Введите число (Для завершения программы нажмите Q): ");
        string value = Console.ReadLine();
        try 
        {
            number = Convert.ToDouble(value);
            if (number > 0 ) result++;
        }
        catch 
        {
            if(value == "Q")
            {
                Console.WriteLine("Количество чисел больше 0: " + result);
                return;
            }
            else
            {
                Console.WriteLine("Вы ввели не число!");
            }
        }
    }
