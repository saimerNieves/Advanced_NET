using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Mathematics;

namespace Mathematics.Test
{
    public class BasicMathTest
    {
        [Fact]
        public void TestAddNumbers() 
        {
            var math = new BasicMath();

            var result_addition = math.AddNumbers(5, 5);
            Assert.True(result_addition == 10);

            

        }

        [Fact]
        public void TestSubtractNumbers()
        {
            var math = new BasicMath();
            var result_subtraction = math.SubtractNumbers(10, 3);
            Assert.True(result_subtraction == 7);
        }
        [Fact]
        public void TestMultiplyNumbers()
        {
            var math = new BasicMath();
            var result_multiplication = math.MultiplyNumbers(5, 6);
            Assert.True(result_multiplication == 30);
        }

        [Fact]

        public void TestDivideNumbers()
        {
            var math = new BasicMath();
            var result_division = math.DivideNumbers(50, 5);
            Assert.True(result_division == 10);
        }





          

            

           
    }
}
