Console.Write("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());

double[,] array = new double[m, n];
 
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

for (int i = 0; i < array.GetLength(0); i++) 
{ double k =0;
    for (int t = 0; t < array.GetLength(1); t++)
        {
            k += array[t, i];
        }
            Console.WriteLine($"Cреднее арифметическое элементов столбца {i + 1} = {k/m}");
}