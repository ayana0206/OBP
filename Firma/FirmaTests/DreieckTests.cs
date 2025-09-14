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
    public class DreieckTests
    {
        [TestMethod()]
        public void CalcUmfangTest()
        {
            // Arrange
            Dreieck dreieck = new Dreieck(4);
            // Act
            int res = dreieck.CalcUmfang();
            // Assert
            Assert.AreEqual(12, res);
        }

        [TestMethod()]
        public void CalcFlaecheTest()
        {
            Assert.Fail();
        }
    }
}