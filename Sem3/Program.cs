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


int[] CreateArray(int size, int min, int max)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i]= new Random().Next(min, max+1);
    }
    return array;
}

bool FindNumInArray(int[] array, int num)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == num)
        {
            return true;
        }
    }
    return false;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i]+ " ");
    }
}

System.Console.Write("Input array size: ");
int size = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Input minimal value of array element: ");
int min = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Input maximal value of array element: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] array = CreateArray(size, min, max);
PrintArray(array);
System.Console.Write("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());
