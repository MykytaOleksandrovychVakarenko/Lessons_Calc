using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons_Switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Number 1:");
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Number 2:");
            int number2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Operation (+, -, *, /):");
            string operation = Console.ReadLine();

            switch(operation)
            {
                case "+":
                    Console.WriteLine($"Result: {number1 + number2}");
                    break;
                case "-":
                    Console.WriteLine($"Result: {number1 - number2}");
                    break;
                case "*":
                    Console.WriteLine($"Result: {number1 * number2}");
                    break;
                case "/":
                    if (number2 != 0)
                    {
                        Console.WriteLine($"Result: {number1 / number2}");
                    }
                    else
                    {
                        Console.WriteLine("Error: Division by zero is not allowed.");
                    }
                    break;
                default:
                    Console.WriteLine("Error: Invalid operation.");
                    break;
            }
            Console.ReadKey();
        }
    }
}
