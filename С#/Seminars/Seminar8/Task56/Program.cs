Console.Write("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[m, n];

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    {
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
                Console.Write($"{array[i, j]}" + "\t");
            Console.WriteLine();
        }
    }
}
FillArray(array);
Console.WriteLine();
PrintArray(array);

int MinSum = 0;
int sum = RowSum(array, 0);
for (int i = 1; i < array.GetLength(0); i++)
{
    int value = RowSum(array, i);
    if (sum > value)
    {
        sum = value;
        MinSum = i;
    }
}

Console.WriteLine($"\n{MinSum + 1} - строкa с наименьшей суммой ({sum}) элементов ");

int RowSum(int[,] array, int i)
{
    int sumLine = array[i, 0];
    for (int j = 1; j < array.GetLength(1); j++)
    {
        sumLine += array[i, j];
    }
    return sumLine;
}