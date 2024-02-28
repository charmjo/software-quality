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

        /*
         *  public void ValidTriangle_TestEquilateral_OutputEquilateralTriangle() {
            // Arrange
            TriangleSides equilateral = new TriangleSides(3, 3, 3);
            String expected = "An equilateral triangle is formed";

            // Act
            String actual = Triangle.AnalyzeTriangle(equilateral.firstSide, equilateral.secondSide, equilateral.thirdSide);

            //Assert
            ClassicAssert.AreEqual(expected , actual);
        }
         */


    }
}
