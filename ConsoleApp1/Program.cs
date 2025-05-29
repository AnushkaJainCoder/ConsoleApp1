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

// mini calculator

Console.WriteLine("Welcome to the Mini Calculator");

//Console.WriteLine("first no. : ");              // writeline add new line after text
Console.Write("first no. :");
int n = int.Parse(Console.ReadLine());        // reads a line from the input stream and converts it to an integer
//int n = Console.Read();                          // reads a single character from the input stream

Console.WriteLine("second no. : ");
int m = int.Parse(Console.ReadLine());
//int m = Console.Read();

int sum = n + m;
Console.WriteLine($"sum is: {sum}");

