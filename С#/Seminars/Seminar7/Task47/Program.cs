Console.Write("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());

double[,] array = new double [m,n];
Random rnd = new Random();

void FillArray (double [,] array)   
{
    for (int i =0; i<m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i,j] = Convert.ToDouble(rnd.Next(0, 100)/10.0);
        }        
    }
}

void PrintArray(double[,] massive1)
{
    { 
        for (int i = 0; i < m; i++)
            {
            for (int j=0; j<n; j++)
                Console.Write($"{massive1[i ,j]}" + " ");
                Console.WriteLine();
            }
    }
}
FillArray(array);
Console.WriteLine();
PrintArray(array);