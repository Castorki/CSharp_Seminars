
// void NumToqUAD(int num)
// {
// System.Console.WriteLine(num * num);
// }

// int NumToqUAD(int num)
// {
//     return num * num;
// }

// System.Console.WriteLine("Input number: ");
// int a = Conver.ToInt32(Console.ReadLine());

// NumToQuad(a);
// int result = NumToQuadInt(a);

// System.Console.WriteLine("Input number; ");
// int a = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine(NumToqUAD(a));

// int DeleteSecondDigit(int num) пример препода return
// {
//     if (num >= 100 && num <= 999)
//     {
//         int ed = num % 10;
//         int sot = num / 100;
//         return sot * 10 + ed;
//     }
//     else
//     {
//         System.Console.WriteLine("You input not three-digit number");
//         return 0;
//     }
// }

// Console.Write("Input three-digit number: ");
// int num = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine(DeleteSecondDigit(num));

// void DeleteSecondDigitVoid(int num) пример препода void
// {
//     if (num >= 100 && num <= 999)
//     {
//         int ed = num % 10;
//         int sot = num / 100;
//         System.Console.WriteLine(sot * 10 + ed);
//     }
//     else
//     {
//         System.Console.WriteLine("You input not three-digit number");
//     }
// }

// Console.Write("Input three-digit number: ");
// int num = Convert.ToInt32(Console.ReadLine());

// // System.Console.WriteLine(DeleteSecondDigit(num));
// DeleteSecondDigitVoid(num);

// int DeleteSecondDigit(int num)  моё
// {
//     if (num >= 100 && num <= 999)
//    {
//     int ed = num % 10;
//     int sot = num / 100;
//     return sot * 10 + ed;
//    }
//    else
//    {
//     System.Console.WriteLine("Yor input not three-digit number");
//     return 0;
//    }

// }
c
// Console.Write("Input three-digit number: ");
// int num = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine(DeleteSecondDigit(num));

// int SecondToThirdPower(int num) пример препода
// {
//     if (num >= 100 && num <= 999)// a b 456 2 3 
//     {
//         int ed = num % 10;
//         int dec = num / 10 % 10;
//         int result = 1;
//         for (int i = 0; i < ed; i++)
//         {
//             result = result * dec;
//         }
//         return result;
//     }
//     else
//     {
//         System.Console.WriteLine("You input not three-digit number");
//         return 0;
//     }
// }

// Console.Write("Input three-digit number: ");
// int num = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine(SecondToThirdPower(num));

// int SecondToThirdPower(int num)  мой пример
// {
//     if (num >= 100 && num <= 999)
//     {
//         int ed = num % 10;
//         int dec = num / 10 % 10;
//         int result = 1;
//         for (int i = 0; i < ed; i++)
//         {
//             result = result * dec;
//         }
//         return result;
//     }
//    else
// //    {
//     System.Console.WriteLine("Yor input not three-digit number");
//     return 0;
//    }
// }

// System.Console.Write("Input three-digit number: ");
// int num = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine(SecondToThirdPower(num));

// void CheckIfDevides(int num1, int num2) моё
// {
//     if (num1 % num2 == 0)
//     {
//         System.Console.WriteLine($"{num1}, {num2} -> yes");
//     }
//     else
//     {
//         System.Console.WriteLine($"{num1}. {num2} -> no, {num1 % num2}");
//     }
// }
// Console.Write("Input first number; ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input seconde number; ");
// int num2 = Convert.ToInt32(Console.ReadLine());

// CheckIfDevides(num1, num2);