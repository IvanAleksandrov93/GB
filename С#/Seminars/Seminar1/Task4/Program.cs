Console.WriteLine("введите первое число");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите второе число");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите третее число");
int f = Convert.ToInt32(Console.ReadLine());

int max = n;

if (n > max)max = n;
if (m > max)max = m;
if (f > max)max = f;

Console.WriteLine("max = ");
Console.WriteLine(max);
