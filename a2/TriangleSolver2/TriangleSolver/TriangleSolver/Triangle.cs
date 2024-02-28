using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleSolver
{
    public static class Triangle
    {
        public static string AnalyzeTriangle(int firstSide, int secondSide, int thirdSide)
        {
            string output;
            if ((firstSide == 0) || (secondSide == 0) || (thirdSide == 0))
            {
                output = "At least one side entered had a zero - invalid triangle";
                return output;
            }

                if (((firstSide + secondSide) > thirdSide) && ((firstSide + thirdSide) > secondSide) && ((secondSide + thirdSide) > firstSide))
                {
                    if ((firstSide == secondSide) && (firstSide == thirdSide) && (secondSide == thirdSide))
                    {
                        output = "An equilateral triangle is formed";
                    }
                    else if ((firstSide == secondSide) || (secondSide == thirdSide) || (thirdSide == firstSide))
                    {
                        output = "An isosceles triangle is formed";

                    }
                    else
                    {
                        output = "A scalene triangle is formed";

                    }


                }
                else
                {
                    output = "A triangle cannot be formed";
                }

            
            return output;
        }
    }
}
