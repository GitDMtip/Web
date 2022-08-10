Console.WriteLine ("Введите 1 число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите 2 число");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите 3 число");
int c = Convert.ToInt32(Console.ReadLine());
if (a > b && a > c)
{
    Console.WriteLine("Максимальное число: " + a);
}
else
 if (b > a && b > c)
{
    Console.WriteLine("Максимальное число: " + b);
}
else
{
    Console.WriteLine("Максимальное число: " + c);
}