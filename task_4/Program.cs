// Задача 22: Напишите программу, которая
// принимает на вход число (N) и выдаёт таблицу
// квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

Console.Clear();
Console.Write("Введите число N: ");
int number = int.Parse(Console.ReadLine()!);

int result = 1;
int pow = 1;

while (result <= number)
{
    pow = result * result;
    Console.WriteLine($"{pow}");
    result++;
}
