using System;

namespace Mathematics
{
    public class BasicMath
    {

        /// <summary>
        /// This is a function that adds 2 numbers together
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>

        public double AddNumbers(double num1, double num2)
        {

            //this adds 2 numbers together
            return num1 + num2;
        }


        /// <summary>
        /// This is a function that subtracts 2 numbers from one another
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        public double SubtractNumbers(double num1, double num2)
        {
            return num1 - num2;
        }


        /// <summary>
        /// This is a function that Multiplies 2 numbers together
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        public double MultiplyNumbers(double num1, double num2)
        {
            return num1 * num2; 
        }
        public double DivideNumbers(double num1, double num2)
        {
            return num1 / num2;
        }
    }
}

