Console.Write("Введите номер дня недели: ");
int n = Convert.ToInt32(Console.ReadLine());
while (n<1|n>7)
{
    Console.Write("Вы ввели недопустимый номер дня недели, повторите ввод (от 1 до 7): ");
    n = Convert.ToInt32(Console.ReadLine());
}
switch (n) 
{
case 1:Console.WriteLine("Понедельник");
Console.WriteLine("Будни, Работайте!");
break;
case 2:Console.WriteLine("Вторник");
Console.WriteLine("Будни, Работайте!");
break;
case 3:Console.WriteLine("Среда");
Console.WriteLine("Среда это маленькая пятница!");
break;
case 4:Console.WriteLine("Четверг");
Console.WriteLine("Будни, Работайте!");
break;
case 5:Console.WriteLine("Пятница");
Console.WriteLine("Выходные начинаются сегодня");
break;
case 6:Console.WriteLine("Суббота");
Console.WriteLine("Выходной!");
break;
case 7:Console.WriteLine("Воскресенье");
Console.WriteLine("Завтра снова на работу");
break;
default:Console.WriteLine("Вы ввели недопустимый номер дня недели");
break;

}