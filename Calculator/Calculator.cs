using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
   
        internal class Calculator
        {

            private double _num1;
            private double _num2;
            private string _operator;
            private double _result;

            public void Start()
            {
                SetOperator();
                SetNumbers();
                PerformOperation();
                DisplayResult();
            }

            private void SetNumbers()
            {
                Console.WriteLine("Enter Number 1:");
                _num1 = GetValidNumber();

                Console.WriteLine("Enter Number 2:");
                _num2 = GetValidNumber();
            }

            private double GetValidNumber()
            {
                while (true)
                {
                    if (double.TryParse(Console.ReadLine(), out double number))
                    {
                        return number;
                    }
                    Console.WriteLine("Invalid input, please enter a valid number:");
                }
            }

            private void SetOperator()
            {
                Console.WriteLine("Welcome to Calculator App");
                Console.WriteLine("Choose one of the operations:");
                Console.WriteLine("1 - Addition");
                Console.WriteLine("2 - Subtraction");
                Console.WriteLine("3 - Multiplication");
                Console.WriteLine("4 - Division");

                _operator = Console.ReadLine();
            }

            private void PerformOperation()
            {
                switch (_operator)
                {
                    case "1":
                        _result = Add(_num1, _num2);
                        break;
                    case "2":
                        _result = Subtract(_num1, _num2);
                        break;
                    case "3":
                        _result = Multiply(_num1, _num2);
                        break;
                    case "4":
                        try
                        {
                            _result = Divide(_num1, _num2);
                        }
                        catch (DivideByZeroException ex)
                        {
                            Console.WriteLine(ex.Message);
                            return;
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid operation selected. Please restart and choose a valid option.");
                        return;
                }
            }

            public double Add(double num1, double num2)
            {



                return num1 + num2;
            }

            public double Subtract(double num1, double num2)
            {
                return num1 - num2;
            }

            public double Multiply(double num1, double num2)
            {
                return num1 * num2;
            }

            public double Divide(double num1, double num2)
            {
                if (num2 == 0)
                {
                    throw new DivideByZeroException("Division by zero is not allowed.");
                }
                return num1 / num2;
            }

            private void DisplayResult()
            {
                Console.WriteLine($"Result is: {_result}");
            }
        }
    
}
