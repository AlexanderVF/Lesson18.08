﻿Console.WriteLine("Введите первое число");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
int b = int.Parse(Console.ReadLine());
int max = a;
if (a < b) max = b;
Console.Write("Максимальное число ");
Console.WriteLine(max);
