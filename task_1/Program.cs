﻿// 17. Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

Console.Clear();
Console.Write("Введите X: ");
int X = int.Parse(Console.ReadLine()!);

Console.Write("Введите y: ");
int Y = int.Parse(Console.ReadLine()!);

if (X > 0 && Y > 0)
{
    Console.WriteLine("1");
}
if (X < 0 && Y > 0)
{
    Console.WriteLine("2");
}
if (X < 0 && Y < 0)
{
    Console.WriteLine("3");
}
if (X > 0 && Y < 0)
{
    Console.WriteLine("4");
}