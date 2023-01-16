// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

//452 -> 11
//82 -> 10
//9012 -> 12

//Вариант 1 
//          int a = int.Parse(Console.ReadLine());
//          int b = 0;
//                while (a > 0)
//          {
//               b = b + a % 10;   
//               a = a / 10;
//          }
//           Console.WriteLine(b);


Console.WriteLine("Вы вводите число,а мы работаем");
int number = Convert.ToInt32(Console.ReadLine());

int sum(int x)
{
    int b = 0;
    while (x > 0)
    {
        b = b + x % 10;
        x = x / 10;
    }
    return b;
}
Console.WriteLine($"{sum(number)}");





