using System;
using Calc;

namespace MyApp
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();

            // can use any operation and return it's resault 

            double a = calculator.Add(10, 52);
            Console.WriteLine(a);
            double m = calculator.Multiply(6.7, 11);
            Console.WriteLine(m);
            double d = calculator.Divide(25, 5);
            Console.WriteLine(d);
        
            double s = calculator.Subtract(17, 14);
            Console.WriteLine(s);
           

            /* double e = calculator.Divide(5,0)
                will throw divide by zero exp
            */

            //  can use start method to start the full calculator app
             
            calculator.Start();


        }
    }

  
}
