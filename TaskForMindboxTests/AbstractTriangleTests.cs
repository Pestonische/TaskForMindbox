using Microsoft.VisualStudio.TestTools.UnitTesting;
using TaskForMindbox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskForMindbox.Tests
{
    [TestClass()]
    public class AbstractTriangleTests
    {
        #region Тест подсчета площади
        [DataTestMethod()]
        [DataRow(5, 2, 6, 4.68)]
        [DataRow(4, 9, 7, 13.42)]
        public void FoundSquareTest(double b, double c, double d, double a)
        {
            Shape shape = new Triangle(b, c, d);
            double outt = shape.FoundSquare();
            Assert.AreEqual(a, Math.Round(outt, 2));
        }
        #endregion

        #region Тест проверяющий существует ли треугольник
        [DataTestMethod()]
        [DataRow(-2, 3, 4)]
        [DataRow(1, 2, 3)]
        [ExpectedException(typeof(Exception), "Такого треугольника не существует.")]
        public void IsShapeExis(double b, double c, double d)
        {
            Shape shape = new Triangle(b, c, d);

        }
        #endregion

        #region Тест проверяющий прямоугольность
        [DataTestMethod()]
        [DataRow(3, 4, 5, true)]
        [DataRow(40, 9, 41, true)]
        [DataRow(10, 9, 4, false)]
        public void IsRectangularTest(double b, double c, double d, bool a)
        {
            Shape shape = new Triangle(b, c, d);
            bool outt = ((Triangle)shape).IsRectangular();
            Assert.AreEqual(a, outt);
        }
        #endregion
    }
}