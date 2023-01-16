Console.WriteLine("Введите ваше число");
int num = Convert.ToInt32(Console.ReadLine());
int i =1;
while (num>0)
{
    i++;
    num/10;
}
Console.WriteLine($"{num}");
