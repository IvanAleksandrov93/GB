// Console.WriteLine("введите первое число");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("введите второе число");
// int m = Convert.ToInt32(Console.ReadLine());
// if (n== m*m )
// {
//     Console.WriteLine("да");
// }
// else 
// {
//     Console.WriteLine("нет");
// }
  

  
int [] array = new int [10];
Console.Write("Ваш Массив: ");
for( int i =0; i< array.Length; i++)
{
    array[i] = new Random().Next(100, 1000);
    Console.Write(array[i] + " ");
}

for( int i =0; i< array.Length /2  ; i++)
{
    int t = array[i];
    array[i] = array[array.Length - i - 1];
    array[array.Length -i - 1] = t;
}

Console.WriteLine();
Console.Write("Перевернутый массив: ");
for (int i=0; i< array.Length; i++)
{
    Console.Write(array[i] + " ");
}
