using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowledgeCheck1_Calculator
{
    public class Calculator
    {
        public static int Add(int first, int second)
        {
            return first + second;
        }

        public static int Subtract(int first, int second)
        {
            return first - second;
        }

        public static int Multiply(int first, int second)
        {
            return first * second;
        }

        public static double Divide(double first, double second)
        {
            return first / second;
        }

        public static void NotAnInt() =>
            Console.WriteLine("One or more of the numbers is not an int");

        public static void GetFactors(string type) =>
            Console.WriteLine($"Enter 2 integers to {type}");

        public static (string, string) GetFactors(string num1, string num2)
        {
            var first = num1;
            var second = num2;
            return (first, second);
        }
    }
}
