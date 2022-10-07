// Задача 21: Напишите программу, которая
// принимает на вход координаты двух точек и
// находит расстояние между ними в 2D
// пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

Console.Clear();
Console.Write("Введите координату Ax: ");
int Ax = int.Parse(Console.ReadLine()!);

Console.Write("Введите координату Bx: ");
int Bx = int.Parse(Console.ReadLine()!);

Console.Write("Введите координату Ay: ");
int Ay = int.Parse(Console.ReadLine()!);

Console.Write("Введите координату By: ");
int By = int.Parse(Console.ReadLine()!);

double Distance = Math.Round(Math.Sqrt(Math.Pow((Bx - Ax), 2) + Math.Pow((By - Ay), 2)),3);
Console.WriteLine($"Расстояние от точки А до точки В равно {Distance}");