﻿Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье число: ");
int c = Convert.ToInt32(Console.ReadLine());

 int max = a;
if (b > max)
{
    b = max;
}
if (c > max)
{
     c = max;
}
Console.Write(max);
