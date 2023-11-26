using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class BasicCalculations
    {
        float num1 = 0;
        float num2 = 0;
        float sum = 0;

        //BASIC CALCULATIONS
        public void Addition()
        {
            Console.WriteLine("\nEnter First Number : ");
            num1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second Number : ");
            num2 = float.Parse(Console.ReadLine());

            sum = num1 + num2;

            Console.WriteLine("The Total is : {0}\n", sum);
        }
        public void Subtract()
        {
            Console.WriteLine("\nEnter First Number : ");
            num1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second Number : ");
            num2 = float.Parse(Console.ReadLine());

            sum = num1 - num2;

            Console.WriteLine("The Total is : {0}\n", sum);
        }
        public void Multiply()
        {
            Console.WriteLine("\nEnter First Number: ");
            num1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second Number: ");
            num2 = float.Parse(Console.ReadLine());

            sum = num1 * num2;

            Console.WriteLine("The Total is : {0}\n", sum);
        }
        public void Divide()
        {
            Console.WriteLine("\nEnter First Number: ");
            num1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second Number: ");
            num2 = float.Parse(Console.ReadLine());

            sum = num1 / num2;

            Console.WriteLine("The Total is : {0}\n", sum);
        }

        //ADVANCED CALCULATIONS
        public void Square()
        {
            Console.WriteLine("\nEnter the Number you want to be Squared: ");
            num1 = float.Parse(Console.ReadLine());

            sum = num1 * num1;

            Console.WriteLine("The Total is : {0}\n", sum);
        }

        public void SquareRoot()
        {
            Console.WriteLine("\nEnter the Number you want the Square Root of: ");
            num1 = float.Parse(Console.ReadLine());

            sum = (float)Math.Sqrt(num1);

            Console.WriteLine("The Total is : {0}\n", sum);
        }
    }
}
