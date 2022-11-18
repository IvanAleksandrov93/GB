﻿Console.Write("Введите M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.WriteLine($"Значение {Ackermann(m, n)}");

int Ackermann(int m, int n) {

    if(m == 0) {
        return n + 1;  
    }
    if(m > 0 && n == 0) {
        return Ackermann(m - 1, 1);
    }
    if(m > 0 && n > 0) {
       return Ackermann(m - 1, Ackermann(m, n - 1));
    }
    return Ackermann(m, n);
}