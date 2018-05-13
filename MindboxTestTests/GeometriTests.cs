using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MindboxTest.Tests
{
    [TestClass()]
    public class GeometriTests
    {
        [TestMethod()]
        public void AreaTriangle_AreaEqual()
        {
            double sideA = 3;
            double sideB = 4;
            double sideC = 5;
            double expected = 6;
            double actual = Geometri.AreaTriangle(sideA, sideB, sideC);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void AreaTriangle_NegativeSide()
        {
            double sideA = -3;
            double sideB = 4;
            double sideC = 5;
            Geometri.AreaTriangle(sideA, sideB, sideC);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void AreaTriangle_WrongSides()
        {
            double sideA = 1;
            double sideB = 2;
            double sideC = 4;
            Geometri.AreaTriangle(sideA, sideB, sideC);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void AreaCircle_NegativeRadius()
        {
            double radius = -1;
            Geometri.AreaCircle(radius);
        }

        [TestMethod]
        public void AreaCircle_AreaEqual()
        {
            double radius = 1.1;
            double expected = 3.8013;
            var delta = 0.0001;
            var actuale = Geometri.AreaCircle(radius);
            Assert.AreEqual(expected, actuale, delta);
        }

        [TestMethod]
        public void AreaAllFigure_AreaEqul()
        {
            double sideA = 3;
            double sideB = 4;
            double sideC = 5;
            double radius = 1.1;
            var delta = 0.0001;
            double expected = 6;
            var actuale = Geometri.AreaAllFigure(sideA, sideB, sideC);
            Assert.AreEqual(expected, actuale);

            expected = 3.8013;
            actuale = Geometri.AreaAllFigure(radius:radius);
            Assert.AreEqual(expected, actuale, delta);

            expected = 12;
            actuale = Geometri.AreaAllFigure(sideA, sideB);
            Assert.AreEqual(expected, actuale);
        }
    }
}