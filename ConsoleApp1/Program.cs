// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


//using System;
//namespace ConsoleApp1
//{
//    class Program
//    {
//        public static void Main(String[] args)
//        {
//            Console.WriteLine("Hello World");
//        }
//    }
//}

//1. mini calculator

    //Console.WriteLine("Welcome to the Mini Calculator");

    ////Console.WriteLine("first no. : ");              // writeline add new line after text
    //Console.Write("first no. :");
    //int n = int.Parse(Console.ReadLine());        // reads a line from the input stream and converts it to an integer
    ////int n = Console.Read();                          // reads a single character from the input stream

    //Console.WriteLine("second no. : ");
    //int m = int.Parse(Console.ReadLine());
    ////int m = Console.Read();

    //int sum = n + m;
    //Console.WriteLine($"sum is: {sum}");


//2. Calculator

Console.WriteLine("-----------------Welcome to the Calculator--------------------");
Console.WriteLine();

String[] op = ["+", "-", "*", "/"];

Console.Write("Enter the operation you want to perform (+, -, *, /): ");
String input_op = Console.ReadLine();
Boolean flag = true;
//int n;
int ans = 0;


while (flag == true)
{
    if (input_op != "+" && input_op != "-" && input_op != "*" && input_op != "/")
    {
        Console.WriteLine("Invalid operation.");
    }
    else
    {
        Console.Write("Enter first number: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Enter second number: ");
        int m = int.Parse(Console.ReadLine());

        if (input_op == "+")
        {
            ans = n + m;
        }
        else if (input_op == "-")
        {
            ans = Math.Abs(n - m);
        }
        else if (input_op == "*")
        {
            ans = Math.Abs(n * m);
        }
        else if (input_op == "/")
        {
            ans = Math.Abs(n / m);
        }

        Console.WriteLine($"Your ans is {ans}");
        
    }

    Console.Write("Prey # to exit / Enter the operation you want to perform (+, -, *, /):");4

    input_op = Console.ReadLine();

    if (input_op == "#")
    {
        flag = false;
        Console.WriteLine("Exiting the calculator. Goodbye!");
        break;
    }
}






