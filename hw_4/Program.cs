﻿Console.Clear();
Console.WriteLine("Введите любое четное число");
int a = int.Parse(Console.ReadLine());
int count = 1;

if (count<=1)
Console.WriteLine("Вы указали неверное число");

while (count <= a)
{
    if (count%2 == 0)
    {
        //Console.WriteLine("Четные числа от 1 до N");
        Console.WriteLine(count  );
    }
    count = count + 1;
}


