using Microsoft.VisualStudio.TestTools.UnitTesting;
using Firma;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firma.Tests
{
    [TestClass()]
    public class RechteckTests
    {
        [TestMethod()]
        public void CalcUmfangTest()
        {
            // Arrange
            Rechteck rechteck = new Rechteck(10, 20);
            // Act
            double res = rechteck.CalcUmfang();
            // Assert
            Assert.AreEqual(20+40, res);
        }

        
        [TestMethod()]
        public void CalcFlaecheTest()
        {
            // Arrange
            Rechteck rechteck = new Rechteck(10, 20);
            // Act
            double res = rechteck.CalcFlaeche();
            // Assert
            Assert.AreEqual(200, res);
        }
    }
}