using System;

namespace calculator_method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Beginning();
        }

        public static void Beginning()
        {
            Console.WriteLine("Calculator");
            MathOperation();
        }

        public static void MathOperation()
        {
            double num1, num2, result;
            string operation;
            result = 0;
            try
            {
                Console.WriteLine("Enter first number");
                num1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter preffered operation (+,-,*,/,%)");
                operation = Console.ReadLine();
                Console.WriteLine("Enter second number");
                num2 = double.Parse(Console.ReadLine());


                switch (operation)
                {
                    case "+":
                        result = AdditionOfNo(num1, num2); break;
                    case "-":
                        result = SubtractionOfNo(num1, num2); break;
                    case "*":
                        result = MultiplicationOfNo(num1, num2); break;
                    case "/":
                        if (num2 == 0)
                        {
                            Console.WriteLine("number cannot be divisable by 0"); return;
                        }
                        else
                        {
                            result = DivisionOfNo(num1, num2); break;
                        }
                    case "%":
                        result = RemainderOfNo(num1, num2); break;
                    default: Console.WriteLine("invalid operation"); return;
                }

                Console.WriteLine($"RESULT\n {num1} {operation} {num2} = {Math.Round(result, 4)} ");
                Console.WriteLine("PRESS ANY KEY TO EXIT");
            }
            catch (Exception ex)
            {

                throw new ArithmeticException(ex.Message);
            }
        }

        public static double AdditionOfNo(double x, double y)
        {
            double result = x + y;
            return result;
        }



        public static double SubtractionOfNo(double x, double y)
        {
            double result = x - y;
            return result;
        }
        public static double MultiplicationOfNo(double x, double y)
        {
            double result = x * y;
            return result;
        }
        public static double DivisionOfNo(double x, double y)
        {
            double result = x / y;
            return result;
        }
        public static double RemainderOfNo(double x, double y)
        {
            double result = x % y;
            return result;
        }

    }



}

