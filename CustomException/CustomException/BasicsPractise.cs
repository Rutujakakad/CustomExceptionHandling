using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomException
{
    internal class BasicsPractise
    {
        public static void Calculate(double num)
        {
            try
            {
                if (num <= 0)
                {
                    throw new ZeroNotAllowedException("Numbers less than zero or zero is not allowed");
                }
                double result = Math.Sqrt(num);
                Console.WriteLine($"Square root of {num} is {result}");
            }
            catch (ZeroNotAllowedException ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

       
        public static void Division(int num, int deno)
        {   
            try
            {
                if (deno == 0)
                {
                    throw new DivByZeroException("Number is less than zero is not allowed");
                }
                int result = num / deno;
                Console.WriteLine($"Result is: {result}");
            }
            catch (DivideByZeroException ex)
            { 
                    Console.WriteLine(ex.ToString());
            }
            
            
            
        }
        public static void NegValue(int x)
        {
            try
            {
                if (x < 0)
                {
                    throw new NegativeValueException("Negative value is not allowed");
                }
               // int x = -3;
                if (x < 0)
                {
                    Console.WriteLine("Value is negative");
                }
                else
                {
                    Console.WriteLine("Value is not negative");
                }
            }
            catch (NegativeValueException ex)
            {
                Console.WriteLine(ex.ToString());
            }
            Console.WriteLine($"The value is: {x}");
        }
    }
}
