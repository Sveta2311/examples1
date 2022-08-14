Console.WriteLine("Введите положительное целое пятизначное число:");
string? a1 = Console.ReadLine() ??"";
int b1;
bool polindrom = true;
char[] arr;
if (!int.TryParse(a1, out b1) || a1.Length != 5)
{
    Console.WriteLine("Ошибка ввода, повторите ввод!");
    return;
}
arr = a1.ToCharArray();
for (int i = 0; i < arr.Length; i++)
{
    if( arr[i] != arr[arr.Length - 1 - i])
    {
        polindrom = false;
    }
}
if(polindrom)
{
    Console.WriteLine("полиндром");
    return;
}
else
{
    Console.WriteLine("не полиндром");
    return;
}