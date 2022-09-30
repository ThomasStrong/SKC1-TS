using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowledgeCheck1_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello. Press 1 for addition, 2 for subtraction, 3 for multiplication, and 4 for division");

            var input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    Calculator.GetFactors("add");
                    var factorsAdd = Calculator.GetFactors(Console.ReadLine(), Console.ReadLine());

                    if (int.TryParse(factorsAdd.Item1, out int addNumOne) && int.TryParse(factorsAdd.Item2, out int addNumTwo))
                    {
                        Console.Write($"{factorsAdd.Item1} + {factorsAdd.Item2} = ");
                        Console.Write(Calculator.Add(addNumOne, addNumTwo));
                    }
                    else
                    {
                        Calculator.NotAnInt();
                    }
                    break;

                case "2":
                    Calculator.GetFactors("subtract");
                    var factorsSubtract = Calculator.GetFactors(Console.ReadLine(), Console.ReadLine());

                    if (int.TryParse(factorsSubtract.Item1, out int subNumOne) && int.TryParse(factorsSubtract.Item2, out int subNumTwo))
                    {
                        Console.Write($"{factorsSubtract.Item1} - {factorsSubtract.Item2} = ");
                        Console.Write(Calculator.Subtract(subNumOne, subNumTwo));
                    }
                    else
                    {
                        Calculator.NotAnInt();
                    }
                    break;

                case "3":
                    Calculator.GetFactors("multiply");
                    var factorsMultiply = Calculator.GetFactors(Console.ReadLine(), Console.ReadLine());

                    if (int.TryParse(factorsMultiply.Item1, out int multNumOne) && int.TryParse(factorsMultiply.Item2, out int multNumTwo))
                    {
                        Console.Write($"{factorsMultiply.Item1} * {factorsMultiply.Item2} = ");
                        Console.Write(Calculator.Multiply(multNumOne, multNumTwo));
                    }
                    else
                    {
                        Calculator.NotAnInt();
                    }
                    break;

                case "4":
                    Calculator.GetFactors("divide");
                    var factorsDivide = Calculator.GetFactors(Console.ReadLine(), Console.ReadLine());

                    if (double.TryParse(factorsDivide.Item1, out double divNumOne) && double.TryParse(factorsDivide.Item2, out double divNumTwo))
                    {
                        Console.Write($"{factorsDivide.Item1} / {factorsDivide.Item2} = ");
                        Console.Write(Calculator.Divide(divNumOne, divNumTwo));
                    }
                    else
                    {
                        Calculator.NotAnInt();
                    }
                    break;

                default:
                    Console.WriteLine("Unknown input");
                    break;
            }
        }
    }
}