//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введи цифру обозначающую день недели,и узнаешь выходной это или нет!: ");
int day = Convert.ToInt32(Console.ReadLine());

void CheckingTheDayOfTheWeek (int dayNumber) {
if (day == 6 || day == 7) {
Console.WriteLine("Уииихаа!Да!");
}
else if (day < 1 || day > 7) {
Console.WriteLine("Эй! Ты забыл сколько дней в неделе?");
}
else Console.WriteLine("Ту ту ту тууу..нет!");
}

CheckingTheDayOfTheWeek(day);
