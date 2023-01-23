// Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.

//[3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

Console.WriteLine("Валяй! Какой размер массива?");
int size = Convert.ToInt32(Console.ReadLine());
double[] numbers = new double[size];
FillArrayRandomNumbers(numbers);
Console.WriteLine("Нарисовал картинку из чисел: ");
PrintArray(numbers);
double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int z = 0; z < numbers.Length; z++)
{
    if (numbers[z] > max)
    {
        max = numbers[z];
    }
    if (numbers[z] < min)
    {
        min = numbers[z];
    }
}

Console.WriteLine($"Самое-присамое MAX значение = {max}, и самое-присамое MIN значение = {min}");
Console.WriteLine($"Когда отнял MIN значение от MAX,получил  = {max - min}. Не благодари!");

void FillArrayRandomNumbers(double[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = Convert.ToDouble(new Random().Next(100, 1000)) / 100;
    }
}
void PrintArray(double[] numbers)
{
    Console.Write("[ ");
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}

