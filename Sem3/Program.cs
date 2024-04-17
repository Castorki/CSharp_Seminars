// Задайте массив. Напишите программу, которая определяет,
// присутствует ли заданное число в массиве. Программа
// должна выдать ответ: Да/Нет.
// Примеры
// [1 3 4 19 3], 8 => Нет
// [-4 3 4 1], 3 => Да


// System.Console.Write("Input your number: ");
// int N = Convert.ToInt32(Console.ReadLine());
// int[] array = {3, 94, 15, 8, 3, 934, 83, 2};
// for (int i = 0; i <= array.Length; i++) 
// {
//     if (i < array.Length) 
//     {
//         if (N == array[i]) 
//         {
//             System.Console.WriteLine("yes");
//             return;
//         }

//     }
//     else 
//     {
//     System.Console.WriteLine("no");
//     }
// }



// int[] CreateArray(int size, int min, int max)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i]= new Random().Next(min, max+1);
//     }
//     return array;
// }

// bool FindNumInArray(int[] array, int num)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] == num)
//         {
//             return true;
//         }
//     }
//     return false;
// }

// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         System.Console.Write(array[i]+ " ");
//     }
// }

// System.Console.Write("Input array size: ");
// int size = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Input minimal value of array element: ");
// int min = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Input maximal value of array element: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] array = CreateArray(size, min, max);
// PrintArray(array);
// System.Console.Write("Input number: ");
// int num = Convert.ToInt32(Console.ReadLine());

// Задайте массив из 10 элементов, заполненный числами из
// промежутка [-10, 10]. Замените отрицательные элементы на
// положительные, а положительные на отрицательные.
// Пример
// [1 -5 6]
// => [-1 5 -6]



// int[] CreateArray(int size, int min, int max)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i]= new Random().Next(min, max+1);
//     }
//     return array;
// }


// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         System.Console.Write(array[i]+ " ");
//     }
//     System.Console.WriteLine();
// }


// int[] ChangeArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = -array[i];
//     }
//     return array;
// }


// System.Console.WriteLine("Input array size: ");
// int size = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input minimal value of arr element: ");
// int min = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input maximal value of arr element: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] array = CreateArray(size, min, max);
// PrintArray(array);

// PrintArray(ChangeArray(array));


// Найдите произведения пар чисел в одномерном массиве. Парой
// считаем первый и последний элемент, второй и предпоследний и
// т.д. Результат запишите в новый массив.
// Пример
// [1 3 2 4 2 3] => [3 6 8]
// [2 3 1 7 5 6 3] => [6 18 5] (элемент 7 не имеет пары)

// using System;
// class Program
// {


// int[] CreateArray(int size, int min, int max)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i]= new Random().Next(min, max+1);
//     }
//     return array;
// }


// int ArrayOfPairs (int array)
// {
//     int[] numbers = new int [array.Length / 2];
//     for (int i = 0; i < array.Length; i++)
//     {
//         numbers[i] = array[array.Length-i-1] * array[i];
//     }
//     return numbers;
// }
// }

// System.Console.WriteLine("Input array size: ");
// int size = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input minimal value of arr element: ");
// int min = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input maximal value of arr element: ");
// int max = Convert.ToInt32(Console.ReadLine());


// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         System.Console.Write(array[i]+ " ");
//     }
//     System.Console.WriteLine();
// }

// int[] array = CreateArray(size, min, max);
// PrintArray(array);

// PrintArray(numbers(array));

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Input array size: ");
        int size = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Input minimal value of arr element: ");
        int min = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Input maximal value of arr element: ");
        int max = Convert.ToInt32(Console.ReadLine());

        int[] array = CreateArray(size, min, max);
        PrintArray(array);

        int[] pairs = ArrayOfPairs(array);
        PrintArray(pairs);
    }

    static int[] CreateArray(int size, int min, int max)
    {
        int[] array = new int[size];
        for (int i = 0; i < size; i++)
        {
            array[i] = new Random().Next(min, max + 1);
        }
        return array;
    }

    static void PrintArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
    }

    static int[] ArrayOfPairs(int[] array)
    {
        int[] numbers = new int[array.Length / 2];
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = array[i] * array[array.Length - i - 1];
        }
        return numbers;
    }
}
