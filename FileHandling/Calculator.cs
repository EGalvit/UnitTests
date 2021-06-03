using System;
using System.Collections.Generic;
using System.Text;

namespace FileHandling
{
    public class Calculator
    {
        public double Addition(double a, double b)
        {
            double sum = a + b;
            return sum;
        }
        public double Multiplication(double a, double b)
        {
            double sum = a * b;
            return sum;
        }
        public double Subtraction(double a, double b)
        {
            double sum = a - b;
            return sum;
        }
        public double Divide(double a, double b)
        {
            double sum = a / b;
            return sum;
        }
    }
}
