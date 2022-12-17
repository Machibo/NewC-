// Напишите программу,которая на вход принимает два числа и выдает,какое число большее ,а какое меньшее
// a=5;b=7;max=7
//a=2;b=10;max=10
//a=-9;b=-3;max=-3
 
Console.WriteLine("Введите свое первое число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите свое второе число");
int b = Convert.ToInt32(Console.ReadLine());
if (a < b)
{
    Console.WriteLine($" Максимальное число = {b}");
}
else if (a > b)
{
    Console.WriteLine($"Максимальное число = {a}");

}
else if (a == b)
{
    Console.WriteLine($"Числа: {a} и {b} равны");

}