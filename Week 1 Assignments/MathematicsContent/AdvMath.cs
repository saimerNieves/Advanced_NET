

using System;
using System.Collections.Generic;

namespace Mathematics
{
    public class AdvMath
    {

        public double areaCalculator(double length, double width)
        {

            return length * width;

        }

        public double averageOfDoubleCalculator(List<double> listofDoubles)
        {
            var sizeOfList = listofDoubles.Count;
            double sumOfList = 0;

            foreach (double number in listofDoubles)
            {
                sumOfList += number;
            }

            
            

            return sumOfList / sizeOfList;


        }

        //Calculate Value Squared (Singular value multiplied by itself)
        public double squareNumberCalculator(double numberToSquare)
        {

            return numberToSquare * numberToSquare;
        }

        //. Calculate Pythagorean Theorem (a2 + b2 = c2). ***HINT The third function should help you with that.
        public double pythagoreanTheoremCalculator(double a, double b)
        {


            return (a * a) + (b * b);

        }

    }
}




