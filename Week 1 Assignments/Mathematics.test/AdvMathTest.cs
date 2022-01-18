using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Mathematics;

namespace Mathematics.Test
{
    public class AdvMathTest
    {

        [Fact]
        public void ValidateAreaCalculator()
        {
            var advMathInstance = new AdvMath();

            var areaResults = advMathInstance.areaCalculator(2, 10);
            Assert.True(areaResults == 20);

        }



        [Fact]
        public void ValidateAverageOfListCalculator()
        {
            var advMathInstance = new AdvMath();
            var listOfDoubles = new List<double>(5) { 0, 1, 2, 3.5, 10 };

            var averageOfList = advMathInstance.averageOfDoubleCalculator(listOfDoubles);
            Assert.True(averageOfList == 3.3);

        }

        [Fact]
        public void ValidateSquareNumberCalculator()
        {
            var advMathInstance = new AdvMath();

            var numberSquared = advMathInstance.squareNumberCalculator(5);
            Assert.True(numberSquared == 25);

        }

        [Fact]
        public void ValidatePythagoreanTheoremCalculator()
        {
            var advMathInstance = new AdvMath();

            var hypothenuseSquared = advMathInstance.pythagoreanTheoremCalculator(3,4);
            Assert.True(hypothenuseSquared == 25);

        }






    }
}
