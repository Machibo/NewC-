// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
//и на выходе показывает вторую цифру этого числа. 
//Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

//456 -> 5
//782 -> 8
//918 -> 1

Console.WriteLine("Введите трёхзначное число, и я скажу какое там второе число!");
int number = Convert.ToInt32(Console.ReadLine());

if (number >= 100 && number <= 999)
{

int numberA= number%100;
int numberB=numberA/10;

Console.WriteLine($"Спасибо! Второе число будет - {numberB}!");
}

else
{
    Console.WriteLine("Данное число не является трехзначным! Введите новое.");
};


//int numberA= number%100;
//int numberB=numberA/10;

//Console.WriteLine($"{numberB}");