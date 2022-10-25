Console.WriteLine("Введите количество элементов массива");
int n = Convert.ToInt32(Console.ReadLine());

int[] array = new int[n];
FillArray(array);
PrintArray(array);
Console.WriteLine();
Chetnii(array);

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
void Chetnii(int[] array)
{
    int  k= 0;
    for( int i=0; i<n; i++)
    {
        if (array[i] %2 ==0)
        {
            k++;
        }
    }
    Console.Write($"Количество четных чисел: {k}");
}