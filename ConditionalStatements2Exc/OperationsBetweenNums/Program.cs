using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperationsBetweenNums
{
    class Program
    {
        static void Main(string[] args)
        {
            //input

            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
            string operation = Console.ReadLine();
            double result = 0.0;
            string evenOrOdd = "";


            //calc

            switch (operation)
            {
                case "+":
                    result = num1 + num2;
                    if (result % 2 == 0)
                    {
                        evenOrOdd = "even";
                    }
                    else
                    {
                        evenOrOdd = "odd";
                    }
                    Console.WriteLine($"{num1} {operation} {num2} = {result} - {evenOrOdd}");
                    break;
                case "-":
                    result = num1 - num2;
                    if (result % 2 == 0)
                    {
                        evenOrOdd = "even";
                    }
                    else
                    {
                        evenOrOdd = "odd";
                    }
                    Console.WriteLine($"{num1} {operation} {num2} = {result} - {evenOrOdd}");
                    break;
                case "*":
                    result = num1 * num2;
                    if (result % 2 == 0)
                    {
                        evenOrOdd = "even";
                    }
                    else
                    {
                        evenOrOdd = "odd";
                    }
                    Console.WriteLine($"{num1} {operation} {num2} = {result} - {evenOrOdd}");
                    break;
                case "/":
                    result = num1 / num2;
                    if (num2 == 0)
                    {
                        Console.WriteLine($"Cannot divide {num1} by zero");
                    }
                    else
                    {
                        Console.WriteLine($"{num1} / {num2} = {result:f2}");
                    }
                    break;
                case "%":
                    result = num1 % num2;
                    if (num2 == 0)
                    {
                        Console.WriteLine($"Cannot divide {num1} by zero");
                    }
                    else
                    {
                        Console.WriteLine($"{num1} % {num2} = {result}");
                    }
                    break;
            }


            //print
        }
    }
}
