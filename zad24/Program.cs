// 
Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

int sumNumbers= SumNumbers(number);
Console.WriteLine($"{sumNumbers}");

int SumNumbers(int num)

{
    int sum = 0;
    for (int i = 1; i <= num; i++)
    {
        sum = sum + i;
    }
    return sum;

}


