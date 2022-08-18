Console.WriteLine("Please, input your number:");
int a = int.Parse(Console.ReadLine());
int b = -a;
while (b <= a)
{
    Console.WriteLine(b);
    b++;
}
