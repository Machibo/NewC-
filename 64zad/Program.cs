// Задача 64: Задайте значение N. Напишите программу,
// которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int N = inputN();
int M = 1;
Console.Write($"N = {N} --> \"");
Console.WriteLine($"{Number(N, M)}\"");
int inputN()
{
    int a = 0;
    try
    {
        Console.Write("Введите N: ");
        a = int.Parse(Console.ReadLine() ?? "");
    }
    catch (Exception ex)
    {
        Console.Write("Не верный формат", ex);
    }
    return a;
}
int Number(int n, int m)
{
    if (n == m)
        return m;
    Console.Write($"{n}, ");
    return Number(n - 1, m);
}