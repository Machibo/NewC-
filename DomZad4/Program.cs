// Напишите программу,которая на вход принимает число(N),
// а на выходе показывает все четные числат от 1 до N.
Console.WriteLine("Выведем четные числа от 1 до Вашего числа");
Console.WriteLine("Введите число");
int n = Convert.ToInt32(Console.ReadLine());
int N = 2;
if ((n > 1))
{
    while (N <= n)
    {
        Console.WriteLine(N + "");
        N = N + 2;
    }
}

