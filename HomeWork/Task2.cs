using System.Security.Cryptography;

internal class Program
{

    private static void Main(string[] args)

    //Task2  Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

    //{
    //    Console.WriteLine("Inter first integer number");
    //    int firstNumber = Int32.Parse(Console.ReadLine());
    //    Console.WriteLine("Inter second integer number");
    //    int secondNumber = Int32.Parse(Console.ReadLine());
    //    if (firstNumber > secondNumber)
    //        Console.WriteLine("Max number - " + firstNumber);
    //    else if (firstNumber < secondNumber)
    //        Console.WriteLine("Max number - " + secondNumber);
    //      else Console.WriteLine("The Numbers are equal");
    //}

    //Task4 Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
    // {
    //    Console.WriteLine("Inter first integer number");
    //    int firstNumberT4 = Int32.Parse(Console.ReadLine());
    //Console.WriteLine("Inter second integer number");
    //    int secondNumberT4 = Int32.Parse(Console.ReadLine());
    //Console.WriteLine("Inter third integer number");
    //    int thirdNumberT4 = Int32.Parse(Console.ReadLine());
    //    int max = firstNumberT4;
    //    if (secondNumberT4 > max) max = secondNumberT4;
    //    if (thirdNumberT4 > max) max = thirdNumberT4;
    //    Console.WriteLine("Max number - " + max);
    //}
    //
    //Task6 Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
    //{
    //    Console.WriteLine("Inter integer number");
    //    int interNumber = Int32.Parse(Console.ReadLine());
    //    if (interNumber % 2 == 0) Console.WriteLine("Четное");
    //    else Console.WriteLine("Нечетное");
    //}
    //Task8 Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
    {
        Console.WriteLine("Inter integer number");
        int interNumber = Int32.Parse(Console.ReadLine());
        int count = 1;
        while (count <= interNumber)
        {
            if (count % 2 == 0)
            {
                Console.Write(count + " ");
            }
            count++;
        }
    }
}


