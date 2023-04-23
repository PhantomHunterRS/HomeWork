using System.ComponentModel.Design;
using System.Security.Cryptography;

internal class Program
{

    private static void Main(string[] args)
    {
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
        //{
        //    Console.WriteLine("Inter integer number");
        //    int interNumber = Int32.Parse(Console.ReadLine());
        //    int count = 1;
        //    while (count <= interNumber)
        //    {
        //        if (count % 2 == 0)
        //        {
        //            Console.Write(count + " ");
        //        }
        //        count++;
        //    }
        //}

        //HomeWork 2
        //Task10 Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа
        //{
        //    Console.WriteLine("enter a three-digit number :");
        //    int enterNumber = Int32.Parse(Console.ReadLine());
        //    enterNumber = enterNumber % 100;
        //    enterNumber = enterNumber / 10;
        //    Console.WriteLine(enterNumber);
        //}
        //Task10 Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа
        //{
        //    Console.WriteLine("enter a three-digit number :");
        //    int enterNumber = Int32.Parse(Console.ReadLine());
        //    string enterThreeDigit = enterNumber.ToString();
        //    Console.WriteLine(enterThreeDigit[1]);
        //}
        //Task13 Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
        //{
        //    Console.WriteLine("enter a number :");
        //    int enterNumber = Int32.Parse(Console.ReadLine());
        //    string enterString = enterNumber.ToString();
        //    if (enterString.Length < 3)
        //    {
        //        Console.WriteLine("There is no third number");
        //    }else
        //    {
        //        Console.WriteLine(enterString[2]);
        //    }
        //}
        //Task15 Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
        //{   string exit = "";
        //    while (exit != "Q")
        //    {
        //    Console.WriteLine("enter a number from 1 to 7 :");
        //    int enterNumber = Int32.Parse(Console.ReadLine());
        //    if (enterNumber > 7 || enterNumber <1 ) {
        //        Console.WriteLine("you entered a number outside the boundary" + "Ah! ah! ah!");
        //    }
        //        switch (enterNumber)
        //        {
        //            case 1:
        //                Console.WriteLine("Monday.Job day");
        //                break;
        //            case 2:
        //                Console.WriteLine("Tuesday.job day");
        //                break;
        //            case 3:
        //                Console.WriteLine("Wednesday.Job day");
        //                break;
        //            case 4:
        //                Console.WriteLine("Thursday.Job day");
        //                break;
        //            case 5:
        //                Console.WriteLine("Friday.Job day.bukhatnitsa");
        //                break;
        //            case 6:
        //                Console.WriteLine("Saturday.Weeeeekend");
        //                break;
        //            case 7:
        //                Console.WriteLine("Sunday.Weekend. :(");
        //                break;
        //        }
        //        Console.WriteLine("enter Q or will you start first");
        //        exit = Console.ReadLine();
        //    }

        //Task19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
        //Console.WriteLine("enter a five-digit number :");
        //string enterNumber = Console.ReadLine();
        //char [] line = enterNumber.ToCharArray();
        //if (line[0] == line[4] && line[1] == line[3]) {
        //    Console.WriteLine("This number is a paradigm");
        //} else { Console.WriteLine("No"); 
        //}

        //Task21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
        //  в нормальном бы приложении я бы писал проверку и выкидывал бы Exseption на предмет ввода пользователя
        //Console.WriteLine("enter the coordinates of the first point separated by commas in 3D:");
        //string [] p1 = Console.ReadLine().Split(',');
        //int[] firstPoint = new int[p1.Length];
        //for (int i = 0; i < p1.Length; i++)
        //{
        //    firstPoint[i] = Int32.Parse(p1[i]);
        //}
        //Console.WriteLine("enter the coordinates of the second point separated by commas in 3D:");
        //string[] p2 = Console.ReadLine().Split(',');
        //int[] secondPoint = new int[p2.Length];
        //for (int i = 0; i < p2.Length; i++)
        //{
        //    secondPoint[i] = Int32.Parse(p2[i]);
        //}
        //double distance = Math.Sqrt(Math.Pow((secondPoint[0]- firstPoint[0]),2) + Math.Pow((secondPoint[1] - firstPoint[1]), 2)+ Math.Pow((secondPoint[2] - firstPoint[2]), 2));
        //Console.WriteLine(distance);

        //Task23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
        //Console.WriteLine("enter the number:");
        //int firstPoint = Int32.Parse(Console.ReadLine());
        //for (int i = 1; i <=firstPoint; i++) {
        //    Console.WriteLine("Number - " + i + " in a cube it is equal to " + Math.Pow(i, 3));
        //}


    }
}


