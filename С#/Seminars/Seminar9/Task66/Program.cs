Console.Write("Введите M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите N: ");
int n = Convert.ToInt32(Console.ReadLine());

numbers(m, n, 0);

void numbers(int number1, int number2, int sum) {

    if (number1 > number2) 
    {
        Console.WriteLine($"Сумма {sum}"); 
        return;
    }
    sum += (number1 ++);
    numbers(number1, number2, sum);
}
