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
    public class AbstractCircleTests
    {
        #region Тест подсчета площади
        [DataTestMethod()]
        [DataRow(1, 3.14)]
        [DataRow(3, 28.26)]        
        public void FoundSquareTest(double b, double a)
        {
            Shape shape = new Circle(b);
            double outt = shape.FoundSquare();
            Assert.AreEqual(a, outt);
        }
        #endregion

        #region Тест проверяющий существует ли круг
        [TestMethod]
        [ExpectedException(typeof(Exception), "Радиус не может быть меньше 0.")]
        public void IsShapeExis()
        {
            Shape shape = new Circle(-2);
        }
        #endregion
    }
}