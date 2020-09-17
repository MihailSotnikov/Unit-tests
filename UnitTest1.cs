using System;
using CalcTests;
using NUnit.Framework;

namespace CalcTestProject1
{
    [TestFixture]


    public class UnitTest1
    {
        [SetUp]
        public void Calc_Open()
        {
            Console.WriteLine("Open console");
        }

        [TearDown]
        public void Calc_Result()
        {
            Console.WriteLine("Take screenshot and save it");
        }

        [OneTimeTearDown]
        public void Calc_Endt()
        {
            Console.WriteLine("Close the console");
        }
        [TestCase(5,7,12)]
        [TestCase(6, 7, 13)]
        [TestCase(5, 2, 7)]
        [TestCase(8, 7, 15)]
        [TestCase(9, 7, 16)]
        public void AddTwoDoubleNumbers(double a, int b, double expected)
        {
            double actRes = new Calculate().Add(a, b);
            Assert.AreEqual(expected, actRes);
          
        }

        [TestCase(5, 7, -2)]
        [TestCase(6.3, 2, 4.3)]
        [TestCase(5, 2, 3)]
        [TestCase(8, 7, 1)]
        [TestCase(9, 7, 2)]
        public void SubstractTwoDoubleNumbers(double a, int b, double expected)
        {
            double actRes = new Calculate().Substract(a, b);
            Assert.AreEqual(expected, actRes);

        }
        [TestCase(5, 7, 35)]
        [TestCase(6.3, 0, 0)]
        [TestCase(5, 2, 10)]
        [TestCase(8, 7, 56)]
        [TestCase(-9, 7, -63)]
        public void MultiplyTwoDoubleNumbers(double a, int b, double expected)
        {
            double actRes = new Calculate().Multiply(a, b);
            Assert.AreEqual(expected, actRes);

        }
        [TestCase(15, 3, 5)]
        [TestCase(6.3, 2, 3.15)]
        [TestCase(5, 2, 2.5)]
        [TestCase(8, 4, 2)]
        [TestCase(-90, -5, 18)]
        public void DivideTwoDoubleNumbers(double a, int b, double expected)
        {
            double actRes = new Calculate().Divide(a, b);
            Assert.AreEqual(expected, actRes);

        }
        [TestCase(20, 100, 20)]
        [TestCase(6, 80, 7.5)]
        [TestCase(5, 20, 25)]
        [TestCase(16, 320, 5)]
        [TestCase(17, 500, 3.4000000000000004d)]
        public void PercentTwoDoubleNumbers(double a, int b, double expected)
        {
            double actRes = new Calculate().Percent(a, b);
            Assert.AreEqual(expected, actRes);

        }

    }

}
