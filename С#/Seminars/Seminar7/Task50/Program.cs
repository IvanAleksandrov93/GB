Console.Write("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[m, n];
 
for (int i = 0; i < array.GetLength(0); i++) 
{
    for (int j = 0; j < array.GetLength(1); j++)
        array [i, j] = Convert.ToInt32(new Random().Next(1,10));  
}
 
for (int i = 0; i < array.GetLength(0); i++) 
{
    for (int j = 0; j < array.GetLength(1); j++)
        Console.Write(array[i,j] + "\t");
        Console.WriteLine();    
}
Console.WriteLine();
Console.WriteLine("Введите координату столбца");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату строки");
int b = Convert.ToInt32(Console.ReadLine());
    if (a>m)
        Console.WriteLine("нет, не угадал, такого элемента");
    if (b>n)
        Console.WriteLine("нет, не угадал, такого элемента");
    else
{
    Object c = array.GetValue(a,b);
    Console.WriteLine();
    Console.WriteLine($"{c}");
}
