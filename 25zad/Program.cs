// Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16


Console.WriteLine("Друг,введите число которое надо возвести в степень");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("А теперь введите степень в которую надо возвести");
int degree = Convert.ToInt32(Console.ReadLine());

if (degree>0)
{
 int result=1;
for (int i = 0; i < degree; i++)
{
    result = result * number;

}  
Console.WriteLine($"Ух ты! {result}!");

}
 
else
{
  Console.WriteLine("Ты ЧЕ? Это не натуральная степень! Исправь!");
}



