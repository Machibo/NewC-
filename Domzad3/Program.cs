// Напишите программу,которая принимает на вход три числа 
// и выдает максимальное из этих трех чисел.
//2,3,7->7;
//44,5,78->78;
//22,3,9->22;

int max;

Console.WriteLine("Нужно ввести три ваших числа через пробел и мы определим какое из них больше.");
Console.WriteLine("Первое число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Второе число");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Третье число");
int c = Convert.ToInt32(Console.ReadLine());
max=a;

if (max < b)
{
    max = b;
}
if (max < c)
{
Console.WriteLine($"Большее из трех чисел = {c}");
}
else
{
    Console.WriteLine($"Большее из трех чисел = {max}");
}

