// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Clear();
Console.Write("Введите число N: ");
int number = int.Parse(Console.ReadLine()!);

int count = 1;
int result = 1;

while (count <= number)
{
    result = count * count * count;
    Console.WriteLine($"{result}");
    count++;
}