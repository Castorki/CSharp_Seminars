﻿//Console.WriteLine("Hello, World!");

// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(a*a);

// Console.Write("Input first number; ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input seconde number; ");
// int num2 = Convert.ToInt32(Console.ReadLine());

// if (num1 == num2 * num2)
// {
//     System.Console.WriteLine($"{num1} is quad of {num2}");
// }

// else
// {
//     System.Console.WriteLine($"{num1} is not quad of {num2}");
// }




// Console.Write("Input three-digit number; ");
// int num = Convert.ToInt32(Console.ReadLine());

// if (num >= 100 && num <= 999)
// {
//     int ed = num % 10;
//     int sot = num / 100;
//     System.Console.WriteLine($"Sum of {ed} and {sot} -> {ed + sot}");
// }
// else
// System.Console.WriteLine("Yor input not three-digit number");

// Console.Write("Input N; ");
// int n = Convert.ToInt32(Console.ReadLine());
// int start = -n;

// while (start <= n)
// {
//     System.Console.Write(start + " ");
//     start ++;
// }

Console.Write("Input N; ");
int n = Convert.ToInt32(Console.ReadLine());
int start = 1;

while (start <= n)
{
    if (start % 2 == 0)

        System.Console.Write(start + " ");
        start ++;

    
}
