using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    /*
     * Write a function called calculate that takes 3 values. The first and third values are numbers. The second value is a character. If the character is "+" , "-", "*", or "/", the function will return the result of the corresponding mathematical function on the two numbers. If the string is not one of the specified characters, the function should return null (throw an ArgumentException in C#).
     * */
    internal class Executes
    {
        public static double Execute(double num1, char op, double num2)
        {
            switch (op)
            {
                case '+':
                    return num1 + num2;
                case '-':
                    return num1 - num2;
                case '*':
                    return num1 * num2;
                case '/':
                    if (num2 != 0)
                    {
                        return num1 / num2;
                    }
                    else
                    {
                        throw new ArgumentException("Cannot divide by zero.");
                    }
                default:
                    throw new ArgumentException("Invalid operator. Please use '+', '-', '*', or '/'.");
            }
        }
    }
}
