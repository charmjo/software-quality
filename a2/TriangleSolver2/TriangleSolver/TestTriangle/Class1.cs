﻿using NUnit.Framework;
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
        public void AnalyzeTriangle_TestEquilateral_OutputEquilateralTriangle() {
            // Arrange
            TriangleSides equilateral = new TriangleSides(3, 3, 3);
            String expected = "An equilateral triangle is formed";

            // Act
            String actual = Triangle.AnalyzeTriangle(equilateral.firstSide, equilateral.secondSide, equilateral.thirdSide);

            //Assert
            ClassicAssert.AreEqual(expected , actual);
        }

        [Test]
        public void AnalyzeTriangle_TestFirstAndSecondEqual_OutputIsoscelesTriangle()
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
        public void AnalyzeTriangle_TestSecondAndThirdEqual_OutputIsoscelesTriangle()
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
        public void AnalyzeTriangle_TestThirdAndFirstEqual_OutputIsoscelesTriangle()
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
        public void AnalyzeTriangle_TestNotAllSidesEqual_OutputScaleneTriangle()
        {
            // Arrange
            TriangleSides scalene = new TriangleSides(23, 29, 31);
            String expected = "A scalene triangle is formed";

            // Act
            String actual = Triangle.AnalyzeTriangle(scalene.firstSide, scalene.secondSide, scalene.thirdSide);

            //Assert
            ClassicAssert.AreEqual(expected, actual);
        }

        [Test]
        public void AnalyzeTriangle_TestNonZeroSides_OutputScaleneTriangle()
        {
            // Arrange
            TriangleSides scalene = new TriangleSides(15, 20, 25);
            String expected = "A scalene triangle is formed";

            // Act
            String actual = Triangle.AnalyzeTriangle(scalene.firstSide, scalene.secondSide, scalene.thirdSide);

            //Assert
            ClassicAssert.AreEqual(expected, actual);
        }

        [Test]
        public void AnalyzeTriangle_TestSumFirstSecGreaterThanThird_OutputScaleneTriangle()
        {
            // Arrange
            TriangleSides scalene = new TriangleSides(5, 7, 3);
            String expected = "A scalene triangle is formed";

            // Act
            String actual = Triangle.AnalyzeTriangle(scalene.firstSide, scalene.secondSide, scalene.thirdSide);

            //Assert
            ClassicAssert.AreEqual(expected, actual);
        }

        [Test]
        public void AnalyzeTriangle_TestSumSecThirdGreaterThanFirst_OutputScaleneTriangle()
        {
            // Arrange
            TriangleSides scalene = new TriangleSides(5, 7, 11);
            String expected = "A scalene triangle is formed";

            // Act
            String actual = Triangle.AnalyzeTriangle(scalene.firstSide, scalene.secondSide, scalene.thirdSide);

            //Assert
            ClassicAssert.AreEqual(expected, actual);
        }

        [Test]
        public void AnalyzeTriangle_TestSumtThirdFirstGreaterThanSec_OutputScaleneTriangle()
        {
            // Arrange
            TriangleSides scalene = new TriangleSides(11, 17, 19);
            String expected = "A scalene triangle is formed";

            // Act
            String actual = Triangle.AnalyzeTriangle(scalene.firstSide, scalene.secondSide, scalene.thirdSide);

            //Assert
            ClassicAssert.AreEqual(expected, actual);
        }

        [Test]
        public void AnalyzeTriangle_TestZeroFirstSide_OutputNotValidTriangle()
        {
            // Arrange
            TriangleSides notValid = new TriangleSides(0, 17, 19);
            String expected = "At least one side entered had a zero - invalid triangle";

            // Act
            String actual = Triangle.AnalyzeTriangle(notValid.firstSide, notValid.secondSide, notValid.thirdSide);

            //Assert
            ClassicAssert.AreEqual(expected, actual);
        }

        [Test]
        public void AnalyzeTriangle_TestZeroSecondSide_OutputNotValidTriangle()
        {
            // Arrange
            TriangleSides notValid = new TriangleSides(11, 0, 19);
            String expected = "At least one side entered had a zero - invalid triangle";

            // Act
            String actual = Triangle.AnalyzeTriangle(notValid.firstSide, notValid.secondSide, notValid.thirdSide);

            //Assert
            ClassicAssert.AreEqual(expected, actual);
        }

        [Test]
        public void AnalyzeTriangle_TestZeroThirdSide_OutputNotValidTriangle()
        {
            // Arrange
            TriangleSides notValid = new TriangleSides(11, 17, 0);
            String expected = "At least one side entered had a zero - invalid triangle";

            // Act
            String actual = Triangle.AnalyzeTriangle(notValid.firstSide, notValid.secondSide, notValid.thirdSide);

            //Assert
            ClassicAssert.AreEqual(expected, actual);
        }

        [Test]
        public void AnalyzeTriangle_TestSideSumFirstSecEqualThird_OutputCannotBeFormed()
        {
            // Arrange
            TriangleSides notValid = new TriangleSides(1, 2, 3);
            String expected = "A triangle cannot be formed";

            // Act
            String actual = Triangle.AnalyzeTriangle(notValid.firstSide, notValid.secondSide, notValid.thirdSide);

            //Assert
            ClassicAssert.AreEqual(expected, actual);
        }

        [Test]
        public void AnalyzeTriangle_TestSideSumSecThirdEqualFirst_OutputCannotBeFormed()
        {
            // Arrange
            TriangleSides notValid = new TriangleSides(12, 4, 8);
            String expected = "A triangle cannot be formed";

            // Act
            String actual = Triangle.AnalyzeTriangle(notValid.firstSide, notValid.secondSide, notValid.thirdSide);

            //Assert
            ClassicAssert.AreEqual(expected, actual);
        }

        [Test]
        public void AnalyzeTriangle_TestSideSumThirdFirstEqualSec_OutputCannotBeFormed()
        {
            // Arrange
            TriangleSides notValid = new TriangleSides(3, 9, 6);
            String expected = "A triangle cannot be formed";

            // Act
            String actual = Triangle.AnalyzeTriangle(notValid.firstSide, notValid.secondSide, notValid.thirdSide);

            //Assert
            ClassicAssert.AreEqual(expected, actual);
        }
    }
}
