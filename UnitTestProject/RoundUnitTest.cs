using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Test_CSharp_Forms.Figures;

namespace UnitTestProject
{
    [TestClass]
    public class RoundUnitTest
    {
        [TestMethod]
        public void AreaTestMethod()
        {
            Round round;
            double area;

            round = new Round(5.0);
            area = round.Area();
            Assert.IsFalse(area == (Math.PI * 25.0), "Incorrect area");
        }
    }
}
