// Задача 13: Напишите программу, 
//которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6
//int result = -1;
Console.WriteLine("Ведите число");
int number = Convert.ToInt32(Console.ReadLine());


if (number >= 100 && number <= 999)
{

    int numberA = number / 100;
    int numberB = number % 100 / 10;
    int numberC = number % 10;

    Console.WriteLine($"Спасибо! Третье число будет - {numberC}!");
}
else if (number<100)
{
        Console.WriteLine($"Упс...Тут нет третьего числа");

};

  
  while (number > 999)
{
   number = number / 100 % 10;
   Console.WriteLine($"Аллилуйя,лови третью цифру {number}");
}
