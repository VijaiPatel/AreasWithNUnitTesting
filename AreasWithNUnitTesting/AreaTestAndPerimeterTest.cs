using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;


namespace AreasWithNUnitTesting
{   [TestFixture]
    class AreaTestAndPerimeterTest
    {
        private FindArea GetAreaCalc()
        {
            var calcarea = new FindArea();
            return calcarea;
        }
        [Test]
        public void RectangleTest()//test rectangle method
        {
            FindArea calcarea = GetAreaCalc();
            double x = 10.0;
            double y = 5;
            double expectedValue = 50;
            double actualValue = calcarea.Rectangle(x, y);
            Assert.AreEqual(expectedValue, actualValue);
        }

        [Test]
        public void CircleTest()// test circle method
        {
            FindArea calcarea = GetAreaCalc();
            double x = 15.0;
            double expectedValue = 706.86;
            double actualValue = calcarea.Circle(x);
            Assert.AreEqual(expectedValue, actualValue);
        }

        [Test]
        public void PossibleTriangleTest()// test triangle method for a possible triangle
        {
            FindArea calcarea = GetAreaCalc();
            double x = 5.0;
            double y = 5.0;
            double z = 5.0;
            double expectedValue = 10.83;
            double actualValue = calcarea.Triangle(x, y, z);
            Assert.AreEqual(expectedValue, actualValue);
        }

        [Test]
        public void ImpossibleTriangleTest()// test triangle method for an impossible triangle
        {
            FindArea calcarea = GetAreaCalc();
            double x = 100.0;
            double y = 1.0;
            double z = 1.0;
            double expectedValue = 0.0;
            double actualValue = calcarea.Triangle(x, y, z);
            Assert.AreEqual(expectedValue, actualValue);
        }

        /*[Test]
        public void TesttoFail()//see if test fails as expected
        {
            FindArea calcarea = GetAreaCalc();
            double x = 10.0;
            double y = 5;
            double expectedValue = 500;
            double actualValue = calcarea.Rectangle(x, y);
            Assert.AreEqual(expectedValue, actualValue);
        }*/
        [Test]
        public void RectanglePerimeterTest()// test rectangle perimeter method 
        {
            FindArea calcarea = GetAreaCalc();
            double x = 5.0;
            double y = 5.0;
            double expectedValue = 20;
            double actualValue = calcarea.RectanglePerimeter(x, y);
            Assert.AreEqual(expectedValue, actualValue);
        }
        [Test]
        public void CirclePerimeterTest()// test circle perimeter method
        {
            FindArea calcarea = GetAreaCalc();
            double x = 15.0;
            double expectedValue = 94.25;
            double actualValue = calcarea.CirclePerimeter(x);
            Assert.AreEqual(expectedValue, actualValue);
        }

        [Test]
        public void TrianglePerimeterTest()// test triangle perimeter method
        {
            FindArea calcarea = GetAreaCalc();
            double x = 5.0;
            double y = 5.0;
            double z = 5.0;
            double expectedValue = 15.0;
            double actualValue = calcarea.TrianglePerimeter(x, y, z);
            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}
