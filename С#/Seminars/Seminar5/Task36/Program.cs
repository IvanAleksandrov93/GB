Console.WriteLine("Введите количество элементов массива");
int n = Convert.ToInt32(Console.ReadLine());

int[] array = new int[n];
FillArray(array);
PrintArray(array);
Console.WriteLine();
SumNeChet(array);

void FillArray(int[] massive)
{
    for (int i =0; i<n; i++)
    {massive[i] = new Random().Next(100, 999);
    }
}
void PrintArray(int[] massive1)
{
    for (int j=0; j<n; j++)
    Console.Write($"{massive1[j]}" + " ");
   
}

void SumNeChet(int[] array)
{
    int sum = 0;
        for (int i = 0; i < n; i += 2)
            sum += array[i];
        Console.WriteLine("сумма элементов с нечетным индексом =" + sum);
}