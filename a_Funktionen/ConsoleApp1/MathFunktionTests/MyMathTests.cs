using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Tests
{
    [TestClass()]
    public class MyMathTests
    {
        [TestMethod()]
        public void Calc_kgVTest()
        {
            // Arrange
            int a = 12;
            int b = 16;
            // Act
            int res = MyMath.Calc_kgV(a, b);
            // Assert
            Assert.AreEqual(48, res);
        }

        [TestMethod()]
        public void Calc_averageTest()
        {
            // Arrange
            int[] array = { 3, 4, 5, 6, 7, 8, 9 };
            // Act
            int res = MyMath.Calc_average(array);
            // Assert
            Assert.AreEqual(6, res);
        }

        [TestMethod()]
        public void Calc_lowestTest()
        {
            // Arrange
            int[] array = { 3, 4, 5, 6, 7, 8, 9 };
            // Act
            int res = MyMath.Calc_lowest(array);
            // Assert
            Assert.AreEqual(3, res);
        }
    }
}