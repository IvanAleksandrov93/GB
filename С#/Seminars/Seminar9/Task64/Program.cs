Console.WriteLine("Введите N");
int number = Convert.ToInt32(Console.ReadLine());
Faclorial(number);
void Faclorial(int n)
{

    if (n == 1)
    {
        Console.Write(n);
    }
    else
    {
        Console.Write(n);
        Faclorial(n - 1);
    }
}
