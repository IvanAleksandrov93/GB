Console.WriteLine("Введите число");
string number = Console.ReadLine();
int length = number.Length;
int res = 0;
for (int i = 0; i < length; i++ )
{
    res = res + (int)Char.GetNumericValue(number[ i ]);
}
Console.WriteLine(res);