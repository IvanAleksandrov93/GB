Console.WriteLine("Введите число");
int n = Convert.ToInt32(Console.ReadLine());

string str = n.ToString();
Console.WriteLine(n);
if (n<100)
Console.WriteLine("третьей цифры нет");
else
Console.WriteLine(str[2]);
