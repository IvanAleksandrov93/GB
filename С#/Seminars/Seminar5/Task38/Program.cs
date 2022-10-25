Console.WriteLine("Введите количество элементов массива");
int n = Convert.ToInt32(Console.ReadLine());
double[] array = new double[n];

FillArray(array);

PrintArray(array);
Console.WriteLine();

Rasnitsa(array);

void FillArray (double [] array)   
{
    Random rnd = new Random();
    for (int i =0; i<array.Length; i++)
    {
        array[i] = Math.Round(rnd.NextDouble()*100, 0);
        }
}

void PrintArray(double[] massive1)
{
    for (int j=0; j<n; j++)
    Console.Write($"{massive1[j]}" + " ");
}

void Rasnitsa (double[] array)
{
    double max = array[0];
    double min = array[0];
    for (int i=0; i<n; i++)
    {
        if (array[i] > max) max = array[i];
        else if (array[i] < min) min = array[i];
    }
    double raz = max - min;
    Console.Write($"{max}" + " ");
    Console.Write($"{min}");
    Console.WriteLine();
    Console.Write($"Разница между max и min: {raz}");
}
