Console.Clear();
Console.WriteLine("Введите первое число");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
int b = int.Parse(Console.ReadLine());
int max = a;
int min = b;

if (b > max) 
{
    max = b;
    min = a;
}
else 
    if (b < max)
{
    max = a;
    min = b;
}


Console.Write("Максимальное число ");
Console.WriteLine(max);
Console.Write("Минимальное число ");
Console.WriteLine(min);
