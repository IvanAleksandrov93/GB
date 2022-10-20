// Console.WriteLine("Введите количество элементов массива"); 
// int n = Convert.ToInt32(Console.ReadLine());
// Random rnd = new Random();
// for (int m = 0; m <= n-1; m++)
//     {
//         if (m > n)
//         break;
        
//         Console.Write(" " + rnd.Next(1,100));       // попытка решить другим методом, 
//     }                                               // но я не смог придумать, как представить
                                                       // Console.Write(" " + rnd.Next(1,100)) в виде массива      
// int a = int.Parse(Console.ReadLine());
// int [] array = new int [n];
// Console.Write(a);
// Console.Write(array[0]);

Console.WriteLine("Введите количество элементов массива");
int n = Convert.ToInt32(Console.ReadLine());
void FillArray(int[] collection)
{
    int length  = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1,100);
        index++;
    }   
}
void PrintArray(int[] col)
{
        int count = col.Length;
        int position = 0;
        while(position < count)
        {
            Console.Write(col[position] + " ");
            position++; 
        }
}

 int[] array = new int[n];
 FillArray(array);
 PrintArray(array);