using NUnit.Framework;
using NUnit.Framework.Legacy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TriangleSolver;

namespace TriangleTest
{

    public class TriangleTest1
    {   // I wanted to have structure for four cases of triangles  
        class TriangleSides
        {
            public int firstSide { get; set; }
            public int secondSide { get; set; }
            public int thirdSide { get; set; }

            public TriangleSides(int firstSide, int secondSide, int thirdSide)
            {
                this.firstSide = firstSide;
                this.secondSide = secondSide;
                this.thirdSide = thirdSide;
            }
        }

        [Test]
        /*
         *        public void NotValidTriangle_TestZeroSides_OutputNotValidTriangle() {

            //Arrange
            List<TriangleSides> testItems = new List<TriangleSides> {
                new TriangleSides(0,5,6),
                new TriangleSides(5, 0, 6),
                new TriangleSides(5, 6, 0)
            };
            String expected = "At least one side entered had a zero - invalid triangle";

            //Act
            List<String> actualList = new List<String>();
            foreach (TriangleSides item in testItems)
            {
                actualList.Add(Triangle.AnalyzeTriangle(item.firstSide, item.secondSide, item.thirdSide));
            }

            //Assert
            foreach (String actual in actualList)
            {
                ClassicAssert.AreEqual(expected, actual);
            }
        }
         */

        public void ValidTriangle_TestEquilateral_OutputEquilateralTriangle() {
            // Arrange
            TriangleSides equilateral = new TriangleSides(3, 3, 3);
            String expected = "An equilateral triangle is formed";

            // Act
            String actual = Triangle.AnalyzeTriangle(equilateral.firstSide, equilateral.secondSide, equilateral.thirdSide);

            //Assert
            ClassicAssert.AreEqual(expected , actual);
        }

        [Test]
        public void ValidTriangle_TestFirstAndSecondEqual_OutputIsoscelesTriangle()
        {
            // Arrange
            TriangleSides isosceles = new TriangleSides(5, 5, 3);
            String expected = "An isosceles triangle is formed";

            // Act
            String actual = Triangle.AnalyzeTriangle(isosceles.firstSide, isosceles.secondSide, isosceles.thirdSide);

            //Assert
            ClassicAssert.AreEqual(expected, actual);
        }

        [Test]
        public void ValidTriangle_TestSecondAndThirdEqual_OutputIsoscelesTriangle()
        {
            // Arrange
            TriangleSides isosceles = new TriangleSides(3, 5, 5);
            String expected = "An isosceles triangle is formed";

            // Act
            String actual = Triangle.AnalyzeTriangle(isosceles.firstSide, isosceles.secondSide, isosceles.thirdSide);

            //Assert
            ClassicAssert.AreEqual(expected, actual);
        }

        [Test]
        public void ValidTriangle_TestThirdAndFirstEqual_OutputIsoscelesTriangle()
        {
            // Arrange
            TriangleSides isosceles = new TriangleSides(5, 3, 5);
            String expected = "An isosceles triangle is formed";

            // Act
            String actual = Triangle.AnalyzeTriangle(isosceles.firstSide, isosceles.secondSide, isosceles.thirdSide);

            //Assert
            ClassicAssert.AreEqual(expected, actual);
        }

        [Test]
        public void ValidTriangle_TestNotAllSidesEqual_OutputScaleneTriangle()
        {
            // Arrange
            TriangleSides isosceles = new TriangleSides(23, 29, 31);
            String expected = "A scalene triangle is formed";

            // Act
            String actual = Triangle.AnalyzeTriangle(isosceles.firstSide, isosceles.secondSide, isosceles.thirdSide);

            //Assert
            ClassicAssert.AreEqual(expected, actual);
        }

        [Test]
        public void ValidTriangle_TestNonZeroSides_OutputScaleneTriangle()
        {
            // Arrange
            TriangleSides isosceles = new TriangleSides(15, 20, 25);
            String expected = "A scalene triangle is formed";

            // Act
            String actual = Triangle.AnalyzeTriangle(isosceles.firstSide, isosceles.secondSide, isosceles.thirdSide);

            //Assert
            ClassicAssert.AreEqual(expected, actual);
        }

        [Test]
        public void ValidTriangle_TestSumFirstSecGreaterThanThird_OutputScaleneTriangle()
        {
            // Arrange
            TriangleSides isosceles = new TriangleSides(5, 7, 3);
            String expected = "A scalene triangle is formed";

            // Act
            String actual = Triangle.AnalyzeTriangle(isosceles.firstSide, isosceles.secondSide, isosceles.thirdSide);

            //Assert
            ClassicAssert.AreEqual(expected, actual);
        }

        [Test]
        public void ValidTriangle_TestSumSecThirdGreaterThanFirst_OutputScaleneTriangle()
        {
            // Arrange
            TriangleSides isosceles = new TriangleSides(5, 7, 11);
            String expected = "A scalene triangle is formed";

            // Act
            String actual = Triangle.AnalyzeTriangle(isosceles.firstSide, isosceles.secondSide, isosceles.thirdSide);

            //Assert
            ClassicAssert.AreEqual(expected, actual);
        }

        [Test]
        public void ValidTriangle_TestSumtThirdFirstGreaterThanSec_OutputScaleneTriangle()
        {
            // Arrange
            TriangleSides isosceles = new TriangleSides(11, 17, 19);
            String expected = "A scalene triangle is formed";

            // Act
            String actual = Triangle.AnalyzeTriangle(isosceles.firstSide, isosceles.secondSide, isosceles.thirdSide);

            //Assert
            ClassicAssert.AreEqual(expected, actual);
        }


    }
}
