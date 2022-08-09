int num = new Random().Next(100, 1000);
int a1 = num / 100;
int a3 = num % 10;
string s1 = a1.ToString();
string s3 = a3.ToString();
string result = s1 + s3;
Console.WriteLine(num);
Console.Write(a1);
Console.WriteLine(a3);