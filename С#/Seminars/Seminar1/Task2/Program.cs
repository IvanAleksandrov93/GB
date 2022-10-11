Console.WriteLine("введите первое число");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите второе число");
int m = Convert.ToInt32(Console.ReadLine());
if(n>m)
{
    Console.WriteLine("Первое число: " + n + " большее, а второе число " + m + " меньшее");
}
else if (m>n)
{
    Console.WriteLine("Второе число: " + m + " большее, а второе число " + n + " меньшее");
}
else Console.WriteLine("Числа: " + n + " и " + m + " равны"); 