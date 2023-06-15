using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
//unable to uninstall gherkin NuGet package

namespace AreasWithNUnitTesting
{   [TestFixture]
    class AreaTestAndPerimeterTest
    {
        private FindArea GetAreaCalc()//factory method for making a new calculator for area methods
        {
            var calcarea = new FindArea();
            return calcarea;
        }
        private FindPerimeter GetPerimeterCalc()//factory method for making a new calculator for perimeter methods
        {
            var calcperimeter = new FindPerimeter();
            return calcperimeter;
        }
        [Test]
        public void RectangleAreaTest()//test rectangle method
        {   //arrange
            FindArea calcarea = GetAreaCalc();
            double x = 10.0;
            double y = 5;
            double expectedValue = 50;
            //act
            double actualValue = calcarea.Rectangle(x, y);
            //assert
            Assert.AreEqual(expectedValue, actualValue);
        }

        [Test]
        public void CircleAreaTest()// test circle method
        {
            FindArea calcarea = GetAreaCalc();//arrange
            double x = 15.0;
            double expectedValue = 706.86;
            double actualValue = calcarea.Circle(x);//act
            Assert.AreEqual(expectedValue, actualValue);//assert
        }

        [Test]
        public void PossibleTriangleAreaTest()// test triangle method for a possible triangle
        {
            FindArea calcarea = GetAreaCalc();//arrange
            double x = 5.0;
            double y = 5.0;
            double z = 5.0;
            double expectedValue = 10.83;
            double actualValue = calcarea.Triangle(x, y, z);//act
            Assert.AreEqual(expectedValue, actualValue);//assert
        }

        [Test]
        public void ImpossibleTriangleTest()// test triangle method for an impossible triangle
        {
            FindArea calcarea = GetAreaCalc();//arrange
            double x = 100.0;
            double y = 1.0;
            double z = 1.0;
            double expectedValue = 0.0;
            double actualValue = calcarea.Triangle(x, y, z);//act
            Assert.AreEqual(expectedValue, actualValue);//assert
        }

        /*[Test]
        public void TesttoFail()//see if test fails as expected
        {
            FindArea calcarea = GetAreaCalc();//arrange
            double x = 10.0;
            double y = 5;
            double expectedValue = 500;
            double actualValue = calcarea.Rectangle(x, y);//act
            Assert.AreEqual(expectedValue, actualValue);//assert
        }*/
        [Test]
        public void RectanglePerimeterTest()// test rectangle perimeter method 
        {
            FindPerimeter calcperimeter = GetPerimeterCalc();//arrange
            double x = 5.0;
            double y = 5.0;
            double expectedValue = 20;
            double actualValue = calcperimeter.RectanglePerimeter(x, y);//act
            Assert.AreEqual(expectedValue, actualValue);//assert
        }
        [Test]
        public void CirclePerimeterTest()// test circle perimeter method
        {
            FindPerimeter calcperimeter = GetPerimeterCalc();//arrange
            double x = 15.0;
            double expectedValue = 94.25;
            double actualValue = calcperimeter.CirclePerimeter(x);//act
            Assert.AreEqual(expectedValue, actualValue);//assert
        }

        [Test]
        public void TrianglePerimeterTest()// test triangle perimeter method
        {
            FindPerimeter calcperimeter = GetPerimeterCalc();//arrange
            double x = 5.0;
            double y = 5.0;
            double z = 5.0;
            double expectedValue = 15.0;
            double actualValue = calcperimeter.TrianglePerimeter(x, y, z);//act
            Assert.AreEqual(expectedValue, actualValue);//assert
        }
    }
}
