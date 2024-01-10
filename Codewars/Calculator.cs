using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    /*
     * You are required to create a simple calculator that returns the result of addition, subtraction, multiplication or division of two numbers.

            Your function will accept three arguments:
            The first and second argument should be numbers.
            The third argument should represent a sign indicating the operation to perform on these two numbers.

            If the sign is not a valid sign, throw an ArgumentException.
    */
    internal class Calculator
    {
        public static double Calculatorz(double a, double b, char op)
        {
            switch (op)
            {
                case '+':
                    return a + b;
                case '-':
                    return a - b;
                case '*':
                    return a * b;
                case '/':

                    if (b == 0)
                    {
                        throw new ArgumentException("Cannot divide by zero.");
                    }
                    return a / b;
                default:
                    throw new ArgumentException("Invalid operation sign. Supported signs are '+', '-', '*', '/'.");
            }
        }
    }
}

