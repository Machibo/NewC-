//Задача 19

//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

//14212 -> нет

//12821 -> да

//23432 -> да


Console.WriteLine("Введите ПЯТИЗНАЧНОЕ число");
int FiveNumber = Convert.ToInt32(Console.ReadLine());

int FiveNumber1 = FiveNumber / 10000;
int FiveNumber2 = (FiveNumber / 1000) % 10;
int FiveNumber3 = (FiveNumber % 1000) / 100;
int FiveNumber4 = (FiveNumber % 100) / 10;
int FiveNumber5 = (FiveNumber % 100) % 10;
if (FiveNumber1 == FiveNumber5 && FiveNumber2 == FiveNumber4)
{
    Console.WriteLine("Ваше число ПОЛИНДРОМ однако!");
}
else
{
    Console.WriteLine("Увы-это НЕ ПОЛИНДРОМ!");
}

//