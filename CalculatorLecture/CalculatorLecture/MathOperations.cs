using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLecture
{
    public class MathOperations
    {
        public static double Add(double num1, double num2)
        {
            double res = num1 + num2;
            return res;
        }
        public static double Substraction(double num1, double num2)
        {
            double res = num1 - num2;
            return res;
        }
        public static double Multiply(double num1, double num2)
        {
            double res = num1 * num2;
            return res;
        }
        public static double Division(double num1, double num2)
        {
            if(num2 == 0)
            {
                throw new DivideByZeroException();
            }
            double res = num1 / num2;
            return res;
        }
        public static double SquareRoot(double num1)
        {
            if (num1 < 0)
            {
                throw new ArithmeticException();
            }
            return Math.Sqrt(num1);
        }
    }
}
