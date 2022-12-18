// Напишите программу ,где 
Console.WriteLine("Введите ваше число,а мы определим четное оно или нет");
int a = Convert.ToInt32(Console.ReadLine());
if (a%2==0)
{
 Console.WriteLine("Ваше число является четным");
}
else if (a%2>0)
{
    Console.WriteLine("Ваше число не является четным"); 
}