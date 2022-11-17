Console.Write("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] arrayA = new int[m, n];

void FillMatrixA(int[,] arrayA)
{
    for (int i = 0; i < arrayA.GetLength(0); i++)
    {
        for (int j = 0; j < arrayA.GetLength(1); j++)
        {
            arrayA[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintMatrixA(int[,] arrayA)
{
    {
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
                Console.Write($"{arrayA[i, j]}" + "\t");
            Console.WriteLine();
        }
    }
}
int[,] arrayB = new int[m, n];

void FillMatrixB(int[,] arrayB)
{
    for (int i = 0; i < arrayB.GetLength(0); i++)
    {
        for (int j = 0; j < arrayB.GetLength(1); j++)
        {
            arrayB[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintMatrixB(int[,] arrayB)
{
    {
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
                Console.Write($"{arrayB[i, j]}" + "\t");
            Console.WriteLine();
        }
    }
}

FillMatrixA(arrayA);
FillMatrixB(arrayB);
Console.WriteLine();
Console.WriteLine("Matrix A");
PrintMatrixA(arrayA);
Console.WriteLine();
Console.WriteLine("Matrix B");
PrintMatrixB(arrayB);

int[,] arrayC = new int[m,n];

FillMatrixC(arrayA, arrayB, arrayC);

void FillMatrixC(int[,] arrayA, int[,] arrayB, int[,] arrayC)
{
    for (int i = 0; i < arrayC.GetLength(0); i++)
    {
        for (int j = 0; j < arrayC.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < arrayA.GetLength(1); k++)
            {
                sum += arrayA[i, k] * arrayB[k, j];
            }
            arrayC[i, j] = sum;
        }
    }
}

void PrintMatrixC(int[,] arrayC)
{
    {
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
                Console.Write($"{arrayC[i, j]}" + "\t");
            Console.WriteLine();
        }
    }
}
FillMatrixC(arrayA, arrayB, arrayC);
Console.WriteLine("Matrix C");
PrintMatrixC(arrayC);
