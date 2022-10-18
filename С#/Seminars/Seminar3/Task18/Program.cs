Console.WriteLine("введите число");
int n = Convert.ToInt32(Console.ReadLine());
string str = n.ToString();

if (str[0]==str[4] && str[1]==str[3])
    { 
        Console.WriteLine ($"полиндром");
    }
else
    {
    Console.WriteLine($"не полиндром");
    }



