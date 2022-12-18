// Напишите программу,которая на вход принимает два числа и выдает,какое число большее ,а какое меньшее
// a=5;b=7;max=7
//a=2;b=10;max=10
//a=-9;b=-3;max=-3

Console.WriteLine("Сейчас мы с вами сравним два числа");
Console.WriteLine("Введите пожалуйста первое число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите пожалуйста второе число");
int b = Convert.ToInt32(Console.ReadLine());

if (a>b)
{
    Console.WriteLine($"Большее из этих двух чисел - {a}");

}

else if (a<b)
{
        Console.WriteLine($"Большее из этих двух чисел - {b}");

}