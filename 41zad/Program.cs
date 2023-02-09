// // Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.


// int[] Arr = inputArr("Введите число:", "Ошибка ввода");
// int res = result(Arr);
// Console.WriteLine($"{String.Join(",", Arr)} --> {res}");
// int[] inputArr(string mesage, string error)

// {
// int[] arr = new int[8];
// for (int i = 0; i < arr.Length; i++)
// {
// Console.Write($"{mesage} {i} из {arr.Length}:");
// bool isCorrect = int.TryParse(Console.ReadLine(), out int n);
// arr[i] = n;
// if (!isCorrect)
// {
//  Console.WriteLine(error);
// break;
// };
// }
// return arr;
// }
// int result(int[] array)
// {
// int result = 0;
// for (int i = 0; i < array.Length; i++)
// {
// if (array[i] > 0)
// {
// result++;
// }
// }
// return result;
// }


// Вариант 2

using System;
class zadacha
{
    static void Main()
    {
        Console.Write("Введи элементы (через пробел): ");
        int[] massiv = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        int count = 0;
        for (int i = 0; i < massiv.Length; i++)
        {
            if (massiv[i] > 0)
            {
                count++;
            }

        }

        Console.WriteLine($"Чисел больше нуля:{count}");

    }
}

