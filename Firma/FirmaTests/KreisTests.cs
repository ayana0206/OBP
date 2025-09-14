using Firma;
using Microsoft.VisualBasic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firma.Tests
{
    [TestClass()]
    public class KreisTests
    {
        [TestMethod()]
        public void CalcUmfangTest()
        {
            // Arrange
            Kreis kreis = new Kreis(6);
            // Act
            double res = kreis.CalcUmfang();
            // Assert
            Assert.AreEqual(37.6999, res);
        }

        [TestMethod()]
        public void CalcFlaecheTest()
        {
            // Arrange
            Kreis kreis = new Kreis(6);
            // Act
            double res = kreis.CalcFlaeche();
            // Assert
            Assert.AreEqual(Math.PI * 36, res);
        }
    }
}